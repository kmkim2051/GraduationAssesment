#pragma checksum "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee8e5cf33eb33d898dc377dc11e39f53561725e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\_ViewImports.cshtml"
using TestProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\_ViewImports.cshtml"
using TestProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
using ReadExcel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee8e5cf33eb33d898dc377dc11e39f53561725e6", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5793b3861753add5f6e734f58173abd93064819", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<IEnumerable<UserSubject>, UserInfo, List<Rule>,List<string>>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee8e5cf33eb33d898dc377dc11e39f53561725e63661", async() => {
                WriteLiteral("\r\n  <meta name=\"viewport\" content=\"width=device-width\" />\r\n  <title>UserView</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee8e5cf33eb33d898dc377dc11e39f53561725e64723", async() => {
                WriteLiteral(@"
    <h3>수강 학점 정보</h3>
    <table cellpadding=""0"" cellspacing=""0"" border=""1"">
        <tr>
            <th>총이수학점</th>
            <th>공통교양</th>
            <th>기본소양</th>
            <th>msc</th>
            <th>수학</th>
            <th>과학</th>
            <th>전산학</th>
            <th>전공</th>
            <th>전필</th>
            <th>전문</th>
            <th>전공설계</th>
            <th>영어</th>
            <th>전공영어</th>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 34 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.totalCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.publicLibCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.basicLibCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.mscCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.mscMathCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.mscScienceCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.mscComputerCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.majorCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.majorEssentialCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.majorSpecialCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.majorDesignCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.englishCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
           Write(Model.Item2.englishMajorCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n    <hr />\r\n    <h3>졸업요건 체크리스트</h3>\r\n");
#nullable restore
#line 51 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
     if (Model.Item3.Count() > 0)
    {
        int passedRule = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral("        <table cellpadding=\"0\" cellspacing=\"0\" border=\"1\">\r\n            <tr>\r\n                <th>번호</th>\r\n                <th>구분</th>\r\n                <th>질문</th>\r\n                <th>만족여부</th>\r\n            </tr>\r\n");
#nullable restore
#line 61 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
             foreach (Rule rule in Model.Item3)
            {
                int ruleNumber = Convert.ToInt32(@rule.number);
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                 if (5 < ruleNumber && ruleNumber < 32)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 67 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                        Write(ruleNumber-5);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 68 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                       Write(rule.type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 69 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                       Write(rule.question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 71 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                             if (@rule.isPassed)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <center>O</center>\r\n");
#nullable restore
#line 74 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                                passedRule += 1;
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <center><b>X</b></center>\r\n");
#nullable restore
#line 79 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 82 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </table>
        <hr />
        <table cellpadding=""0"" cellspacing=""0"" border=""1"">
            <tr>
                <th>졸업가능여부</th>
                <th>만족조건/전체조건</th>
            </tr>
            <tr>
                <td>
                    <center>
");
#nullable restore
#line 94 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                         if (passedRule < 26)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <b>Fail</b>\r\n");
#nullable restore
#line 97 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <b>Pass</b>\r\n");
#nullable restore
#line 101 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </center>\r\n                </td>\r\n                <td>\r\n                    <center>");
#nullable restore
#line 105 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
                       Write(passedRule);

#line default
#line hidden
#nullable disable
                WriteLiteral(" / 26</center>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 109 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
     if (Model.Item4.Count() > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("   <hr />\r\n        <table cellpadding=\"0\" cellspacing=\"0\" border=\"1\">\r\n");
#nullable restore
#line 113 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
         foreach (string exception in Model.Item4)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 116 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
               Write(exception);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 118 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
#nullable restore
#line 120 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<IEnumerable<UserSubject>, UserInfo, List<Rule>,List<string>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
