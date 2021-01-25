#pragma checksum "D:\wddn\sudoku\sudoku\Views\SudokuProblems\Sudoku.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95b0a38bdbd3b21d400be12968726f070338a5b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SudokuProblems_Sudoku), @"mvc.1.0.view", @"/Views/SudokuProblems/Sudoku.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SudokuProblems/Sudoku.cshtml", typeof(AspNetCore.Views_SudokuProblems_Sudoku))]
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
#line 1 "D:\wddn\sudoku\sudoku\Views\_ViewImports.cshtml"
using sudoku;

#line default
#line hidden
#line 2 "D:\wddn\sudoku\sudoku\Views\_ViewImports.cshtml"
using sudoku.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95b0a38bdbd3b21d400be12968726f070338a5b6", @"/Views/SudokuProblems/Sudoku.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa63221bb736f372783c967971764e83f5c68e29", @"/Views/_ViewImports.cshtml")]
    public class Views_SudokuProblems_Sudoku : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SudokuProblem>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Sudoku.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\wddn\sudoku\sudoku\Views\SudokuProblems\Sudoku.cshtml"
  
    ViewData["Title"] = "Sudoku";

#line default
#line hidden
            BeginContext(64, 11683, true);
            WriteLiteral(@"
<style type=""text/css"">

    #grid {
        border: 2px solid #000000;
        align-self: center;
    }

    td {
        border: 1px solid #000000;
        text-align: center;
        vertical-align: middle;
    }

    input {
        color: #000000;
        padding: 0;
        border: 0;
        text-align: center;
        width: 48px;
        height: 48px;
        font-size: 24px;
        background-color: #FFFFFF;
        outline: none;
    }

        input:disabled {
            background-color: #EEEEEE;
        }

    #cell-0, #cell-1, #cell-2 {
        border-top: 2px solid #000000;
    }

    #cell-2, #cell-11, #cell-20 {
        border-right: 2px solid #000000;
    }

    #cell-18, #cell-19, #cell-20 {
        border-bottom: 2px solid #000000;
    }

    #cell-0, #cell-9, #cell-18 {
        border-left: 2px solid #000000;
    }

    #cell-3, #cell-4, #cell-5 {
        border-top: 2px solid #000000;
    }

    #cell-5, #cell-14, #cell-23 {
       ");
            WriteLiteral(@" border-right: 2px solid #000000;
    }

    #cell-21, #cell-22, #cell-23 {
        border-bottom: 2px solid #000000;
    }

    #cell-3, #cell-12, #cell-21 {
        border-left: 2px solid #000000;
    }

    #cell-6, #cell-7, #cell-8 {
        border-top: 2px solid #000000;
    }

    #cell-8, #cell-17, #cell-26 {
        border-right: 2px solid #000000;
    }

    #cell-24, #cell-25, #cell-26 {
        border-bottom: 2px solid #000000;
    }

    #cell-6, #cell-15, #cell-24 {
        border-left: 2px solid #000000;
    }

    #cell-27, #cell-28, #cell-29 {
        border-top: 2px solid #000000;
    }

    #cell-29, #cell-38, #cell-47 {
        border-right: 2px solid #000000;
    }

    #cell-45, #cell-46, #cell-47 {
        border-bottom: 2px solid #000000;
    }

    #cell-27, #cell-36, #cell-45 {
        border-left: 2px solid #000000;
    }

    #cell-30, #cell-31, #cell-32 {
        border-top: 2px solid #000000;
    }

    #cell-32, #cell-41, #cell-50 {
            WriteLiteral(@"
        border-right: 2px solid #000000;
    }

    #cell-48, #cell-49, #cell-50 {
        border-bottom: 2px solid #000000;
    }

    #cell-30, #cell-39, #cell-48 {
        border-left: 2px solid #000000;
    }

    #cell-33, #cell-34, #cell-35 {
        border-top: 2px solid #000000;
    }

    #cell-35, #cell-44, #cell-53 {
        border-right: 2px solid #000000;
    }

    #cell-51, #cell-52, #cell-53 {
        border-bottom: 2px solid #000000;
    }

    #cell-33, #cell-42, #cell-51 {
        border-left: 2px solid #000000;
    }

    #cell-54, #cell-55, #cell-56 {
        border-top: 2px solid #000000;
    }

    #cell-56, #cell-65, #cell-74 {
        border-right: 2px solid #000000;
    }

    #cell-72, #cell-73, #cell-74 {
        border-bottom: 2px solid #000000;
    }

    #cell-54, #cell-63, #cell-72 {
        border-left: 2px solid #000000;
    }

    #cell-57, #cell-58, #cell-59 {
        border-top: 2px solid #000000;
    }

    #cell-59, #cell-6");
            WriteLiteral(@"8, #cell-77 {
        border-right: 2px solid #000000;
    }

    #cell-75, #cell-76, #cell-77 {
        border-bottom: 2px solid #000000;
    }

    #cell-57, #cell-66, #cell-75 {
        border-left: 2px solid #000000;
    }

    #cell-60, #cell-61, #cell-62 {
        border-top: 2px solid #000000;
    }

    #cell-62, #cell-71, #cell-80 {
        border-right: 2px solid #000000;
    }

    #cell-78, #cell-79, #cell-80 {
        border-bottom: 2px solid #000000;
    }

    #cell-60, #cell-69, #cell-78 {
        border-left: 2px solid #000000;
    }
</style>

<div class=""card rounded-0 p-5"">

    <table id=""grid"">

        <tr>
            <td><input id=""cell-0"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-1"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-2"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-3"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            WriteLiteral(@"
            <td><input id=""cell-4"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-5"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-6"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-7"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-8"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
        </tr>

        <tr>
            <td><input id=""cell-9"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-10"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-11"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-12"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-13"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-14"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <");
            WriteLiteral(@"td><input id=""cell-15"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-16"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-17"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
        </tr>

        <tr>
            <td><input id=""cell-18"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-19"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-20"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-21"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-22"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-23"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-24"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-25"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input ");
            WriteLiteral(@"id=""cell-26"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
        </tr>

        <tr>
            <td><input id=""cell-27"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-28"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-29"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-30"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-31"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-32"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-33"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-34"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-35"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
        </tr>

        <tr>
            <td><input id=""cell-36"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
  ");
            WriteLiteral(@"          <td><input id=""cell-37"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-38"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-39"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-40"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-41"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-42"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-43"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-44"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
        </tr>

        <tr>
            <td><input id=""cell-45"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-46"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-47"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

          ");
            WriteLiteral(@"  <td><input id=""cell-48"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-49"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-50"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-51"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-52"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-53"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
        </tr>

        <tr>
            <td><input id=""cell-54"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-55"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-56"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-57"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-58"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><inp");
            WriteLiteral(@"ut id=""cell-59"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-60"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-61"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-62"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
        </tr>

        <tr>
            <td><input id=""cell-63"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-64"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-65"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-66"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-67"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-68"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-69"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""c");
            WriteLiteral(@"ell-70"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-71"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
        </tr>

        <tr>
            <td><input id=""cell-72"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-73"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-74"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-75"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-76"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-77"" type=""text"" onfocusout=""cellValueChanged(id)""></td>

            <td><input id=""cell-78"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-79"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
            <td><input id=""cell-80"" type=""text"" onfocusout=""cellValueChanged(id)""></td>
        </tr>

    </table>
    <di");
            WriteLiteral(@"v id=""finish"" hidden>
        <h1 class=""text-success"">Congratulations Genius!!</h1>
        <h4 class=""text-success"">You Solved It Right</h4>
    </div>
    <div id=""buttons"" class=""text-center p-5"">
        <button value=""reset"" class=""btn btn-primary"" onclick=""resetSudoku()"">Reset</button>
        <button value=""Finish"" class=""btn btn-primary"" onclick=""finishSudoku()"">Finish</button>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(11764, 7, true);
                WriteLiteral(" \r\n    ");
                EndContext();
                BeginContext(11771, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95b0a38bdbd3b21d400be12968726f070338a5b616395", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11809, 65, true);
                WriteLiteral("\r\n    <script>\r\n        refreshNavbar();\r\n        let problem = \"");
                EndContext();
                BeginContext(11875, 13, false);
#line 325 "D:\wddn\sudoku\sudoku\Views\SudokuProblems\Sudoku.cshtml"
                  Write(Model.Problem);

#line default
#line hidden
                EndContext();
                BeginContext(11888, 26, true);
                WriteLiteral("\";\r\n        let result = \"");
                EndContext();
                BeginContext(11915, 12, false);
#line 326 "D:\wddn\sudoku\sudoku\Views\SudokuProblems\Sudoku.cshtml"
                 Write(Model.Result);

#line default
#line hidden
                EndContext();
                BeginContext(11927, 2209, true);
                WriteLiteral(@""";
        
        var i;
        for (i = 0; i < 81; i++) {
            if (problem[i] != ""0"") {
                document.getElementById(""cell-"" + i).value = problem[i];
                document.getElementById(""cell-"" + i).disabled = true;
            }
            else {
                document.getElementById(""cell-"" + i).disabled = false;
            }
        }

        function cellValueChanged(index) {
            id = index.substring(5);
            if (document.getElementById(index).value == result[id]) {
                document.getElementById(index).disabled = true;
                document.getElementById(index).style.backgroundColor = ""#A0EBDB"";
            }
            else if (document.getElementById(index).value != """") {
                document.getElementById(index).style.backgroundColor = ""#EBA0A7"";
            }
            else {
                document.getElementById(index).style.backgroundColor = ""#FFFFFF"";
            }
        }

        function finishSudo");
                WriteLiteral(@"ku() {
            let flag = true;
            for (i = 0; i < 81; i++) {
                if (document.getElementById(""cell-"" + i).value != result[i]) {
                    flag = false;
                    alert(""Sudoku is Incorrect"");
                    break;
                }
            }
            if (flag == true) {
                document.getElementById(""finish"").hidden = false;
                document.getElementById(""buttons"").hidden = true;
                document.getElementById(""grid"").hidden = true;
            }
        }

        function resetSudoku() {
            for (i = 0; i < 81; i++) {
                if (problem[i] != ""0"") {
                    document.getElementById(""cell-"" + i).value = problem[i];
                    document.getElementById(""cell-"" + i).disabled = true;
                }
                else {
                    document.getElementById(""cell-"" + i).value = """";
                    document.getElementById(""cell-"" + i).disabled = false;
 ");
                WriteLiteral("                   document.getElementById(\"cell-\" + i).style.backgroundColor = \"#FFFFFF\"\r\n                }\r\n            }\r\n        }\r\n        \r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SudokuProblem> Html { get; private set; }
    }
}
#pragma warning restore 1591