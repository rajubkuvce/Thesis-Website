﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commander.Models;
using Commander.Data;
using AutoMapper;
using Commander.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace Commander.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepo _repository;
        private IMapper _mapper;

        public UserController(IUserRepo repostory, IMapper mapper)
        {
            _repository = repostory;
            _mapper= mapper;
        }
        
        //[Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<UserReadDto>> GetAllUsers()
        {
            var userItems = _repository.GetAllUsers();
            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(userItems));
        }

        //[Authorize]
        [HttpGet("{id}", Name="GetUserByIdd")]
        public ActionResult <UserReadDto> GetUserById(int id)
        {
            var userItem = _repository.GetUserById(id);
            if(userItem!=null)
            {
                return Ok(_mapper.Map<UserReadDto>(userItem));
            }
            return NotFound();
        }

        //[Authorize]
        [HttpPost]
        public ActionResult<UserReadDto> CreateUser(UserCreateDto userCreateDto)
        {
            var userModel = _mapper.Map<User>(userCreateDto);
            _repository.CreateUser(userModel);
            _repository.SaveChanges();

            var userReadDto = _mapper.Map<UserReadDto>(userModel);

            return GetUserById(userReadDto.Id);
        }

        //[Authorize]
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, UserUpdateDto userUpdateDto)
        {
            var userModelFromRepo = _repository.GetUserById(id);
            if(userUpdateDto == null)
            {
                return NotFound();
            }

            _mapper.Map(userUpdateDto, userModelFromRepo);

            _repository.UpdateUser(userModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //[Authorize]
        [HttpPatch("{id}")]
        public ActionResult PartialUserUpdate(int id, JsonPatchDocument<UserUpdateDto> pathDoc)
        {
            var userModelFromRepo = _repository.GetUserById(id);
            if(userModelFromRepo == null)
            {
                return NotFound();
            }

            var userToPatch = _mapper.Map<UserUpdateDto>(userModelFromRepo);
            pathDoc.ApplyTo(userToPatch, ModelState);
            if(!TryValidateModel(userToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(userToPatch,userModelFromRepo);

            _repository.UpdateUser(userModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var userModelFromRepo = _repository.GetUserById(id);
            if(userModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteUser(userModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}