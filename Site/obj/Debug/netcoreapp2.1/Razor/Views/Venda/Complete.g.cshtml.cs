#pragma checksum "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 4\Modulo 4_Projeto\Site\Views\Venda\Complete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f35a110a427c87c1d448539dc80535009d8d8ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venda_Complete), @"mvc.1.0.view", @"/Views/Venda/Complete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Venda/Complete.cshtml", typeof(AspNetCore.Views_Venda_Complete))]
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
#line 1 "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 4\Modulo 4_Projeto\Site\Views\_ViewImports.cshtml"
using Site;

#line default
#line hidden
#line 2 "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 4\Modulo 4_Projeto\Site\Views\_ViewImports.cshtml"
using Site.Models;

#line default
#line hidden
#line 3 "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 4\Modulo 4_Projeto\Site\Views\_ViewImports.cshtml"
using Site.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 4\Modulo 4_Projeto\Site\Views\_ViewImports.cshtml"
using Site.Repositorios;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f35a110a427c87c1d448539dc80535009d8d8ed", @"/Views/Venda/Complete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23aa78d600ad834ce08970225aebe5a501dec023", @"/Views/_ViewImports.cshtml")]
    public class Views_Venda_Complete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarrinhoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 27, true);
            WriteLiteral("<h1>\r\n    Dados Recebidos. ");
            EndContext();
            BeginContext(54, 15, false);
#line 3 "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 4\Modulo 4_Projeto\Site\Views\Venda\Complete.cshtml"
                Write(TempData["msg"]);

#line default
#line hidden
            EndContext();
            BeginContext(69, 30, true);
            WriteLiteral("\r\n\r\n</h1>\r\n\r\n<H4>Valor Total: ");
            EndContext();
            BeginContext(100, 19, false);
#line 7 "C:\Users\cvalmeida\Documents\Visual Studio 2017\Projects\Curso Asp.Net Core\Modulo 4\Modulo 4_Projeto\Site\Views\Venda\Complete.cshtml"
            Write(Model.TotalCarrinho);

#line default
#line hidden
            EndContext();
            BeginContext(119, 40, true);
            WriteLiteral("</H4>\r\n\r\n<h4>Formas de Pagamentos</h4>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarrinhoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
