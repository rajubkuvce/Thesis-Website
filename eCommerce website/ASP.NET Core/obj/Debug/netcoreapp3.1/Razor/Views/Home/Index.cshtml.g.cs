#pragma checksum "E:\GIT HUB\Thesis-Website\eCommerce website\ASP.NET Core\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7973fa85596a1bd74573dabfec72346fca4bf170"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\GIT HUB\Thesis-Website\eCommerce website\ASP.NET Core\Views\_ViewImports.cshtml"
using ASP.NET_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GIT HUB\Thesis-Website\eCommerce website\ASP.NET Core\Views\_ViewImports.cshtml"
using ASP.NET_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7973fa85596a1bd74573dabfec72346fca4bf170", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cece8e97a48c14dc69f1e4bcc04dd0d337cf55c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\GIT HUB\Thesis-Website\eCommerce website\ASP.NET Core\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Swift Claw";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container"">
        <hr />
        <div class=""text-center"">
            <h1 class=""display-4"">Swift Claw</h1>
        </div>
        <hr />
    </div>


    <div class=""container"">
        <div class=""jumbotron jumbotron-fluid"" style=""background-image:url(https://s5.gifyu.com/images/IMG_20191208_180520-1-1.png); border-radius:0;"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6 text-center"">
                        <h1 class=""display-4"" style=""color:white; -webkit-text-stroke:2.5px #2E0D5F; font-family:Verdana""><em>Postani deo Kandžica!</em></h1>
                        <p class=""lead"" style=""color:white; -webkit-text-stroke:1px #2E0D5F; font-size:25px; font-family:Verdana""><em>Prva kupovina 20% popusta!</em></p>
                        <button type=""button"" class=""btn btn-outline-light"">Kupi odmah</button>
                    </div>
                    <div class=""col-md-6"">
                        <h1></h1>");
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>

<!--dugme
<button class=""open-button"" onclick=""openForm()""><img src=""slike/logo.png"" height=""50"" width=""50""></button>

<div class=""chat-popup"" id=""myForm"">
    <form action=""/action_page.php"" class=""form-container"">
        <h1>Čet</h1>

        <label for=""msg""><b>Poruka</b></label>
        <textarea placeholder=""Napiši poruku..."" name=""msg"" required></textarea>

        <button type=""submit"" class=""btn"">Pošalji</button>
        <button type=""button"" class=""btn cancel"" onclick=""closeForm()"">Zatvori</button>
    </form>
</div>
    <img src=""https://s5.gifyu.com/images/IMG_20191208_180520.jpg"" style="" height:100%; width:100%"" class=""img-fluid"">
-->
<br>
<br>
<br>

<div class=""container"">
    <p style=""font-size: 25px;text-align: center""><em>Naši proizvodi</em></p>
    <div class=""row"">
        <div class=""col-sm-4"">
            <div class=""panel panel-default"">
                <div cl");
            WriteLiteral(@"ass=""panel-heading"" style=""background-color:#200843;color:white"">NOVI PROIZVODI</div>
                <div class=""panel-body""><img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width: 100%"" alt=""Image""></div>
                <div class=""panel-footer"">Novi proizvodi u kolekciji</div>
            </div>
        </div>
        <div class=""col-sm-4"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"" style=""background-color:#200843;color:white"">NAJPRODAVANIJE</div>
                <div class=""panel-body""><img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width: 100% "" alt=""Image""></div>
                <div class=""panel-footer"">Trenutno najprodavanije</div>
            </div>
        </div>
        <div class=""col-sm-4"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"" style=""background-color:#200843;color:white"">POPUSTI</div>
                <div class=""panel-body");
            WriteLiteral(@"""><img src=""https://placehold.it/150x80?text=IMAGE"" class=""img-responsive"" style=""width:100%"" alt=""Image""></div>
                <div class=""panel-footer"">Proizvodi koji su na popustu</div>
            </div>
        </div>
    </div>
</div>
<br>

<div class=""container"">
    <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
        <!-- Indicators -->
        <ol class=""carousel-indicators"">
            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
            <li data-target=""#myCarousel"" data-slide-to=""3""></li>
            <li data-target=""#myCarousel"" data-slide-to=""4""></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class=""carousel-inner"">
            <div class=""item active"">
                <img src=""https://s5.gifyu.com/images/IMG_20191208_183750-2.png"" alt=""logogamescon"" style=""width:100%;"">");
            WriteLiteral(@"
            </div>

            <div class=""item"">
                <img src=""https://s5.gifyu.com/images/IMG-20191207-WA0014.jpg"" alt=""ekipa"" style=""width:100%;"">
            </div>

            <div class=""item"">
                <img src=""https://s5.gifyu.com/images/IMG_20191208_180520.jpg"" alt=""majicasc"" style=""width:100%;"">
            </div>

            <div class=""item"">
                <img src=""https://s5.gifyu.com/images/IMG_20191208_182416.jpg"" alt=""asusrog"" style=""width:100%;"">
            </div>

            <div class=""item"">
                <img src=""https://s5.gifyu.com/images/IMG_20191208_174034.jpg"" alt=""monster"" style=""width:100%;"">
            </div>

        </div>

        <!-- Left and right controls -->
        <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">
            <span class=""glyphicon glyphicon-chevron-left""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""right carousel-control"" href=""#myC");
            WriteLiteral(@"arousel"" data-slide=""next"">
            <span class=""glyphicon glyphicon-chevron-right""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>

<div class=""container"">
    <div class=""row"">
        <p style=""font-size: 20px; text-align: center; "">
            <strong>
                Games.con je najveći festival gejminga i pop kulture u regionu, stvoren sa idejom da na jednom mestu okupi sve ljubitelje
                svih vrsta igara – od virtuelne realnosti, preko PC i mobile gejminga i konzola, sve do tradicionalnih društvenih igara.
            </strong>
        </p>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
