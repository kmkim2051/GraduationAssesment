#pragma checksum "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0ac227bd9601edc88e25c7c35e06cd8d3e2c88d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_userview), @"mvc.1.0.view", @"/Views/User/userview.cshtml")]
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
#line 1 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
using ReadExcel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0ac227bd9601edc88e25c7c35e06cd8d3e2c88d", @"/Views/User/userview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5793b3861753add5f6e734f58173abd93064819", @"/Views/_ViewImports.cshtml")]
    public class Views_User_userview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<IEnumerable<UserSubject>, UserInfo, List<Rule>>>
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
#line 3 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
  
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- 안쓰는 페이지 08.22 -->\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0ac227bd9601edc88e25c7c35e06cd8d3e2c88d3691", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0ac227bd9601edc88e25c7c35e06cd8d3e2c88d4753", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"  <table cellpadding=""0"" cellspacing=""0"" border=""1"">
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
#line 71 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.totalCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 72 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.publicLibCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 73 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.basicLibCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 74 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.mscCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 75 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.mscMathCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 76 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.mscScienceCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 77 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.mscComputerCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 78 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.majorCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 79 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.majorEssentialCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 80 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.majorSpecialCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 81 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.majorDesignCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 82 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.englishCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 83 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
     Write(Model.Item2.englishMajorCredit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n    </tr>\r\n  </table>\r\n  <hr />\r\n");
                WriteLiteral("  <p>");
#nullable restore
#line 98 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
 Write(Model.Item3.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 99 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
   if (Model.Item3.Count() > 0)
  {
    int passedRule = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral("    <hr />\r\n    <table cellpadding=\"0\" cellspacing=\"0\" border=\"1\">\r\n      <tr>\r\n        <th>번호</th>\r\n        <th>구분</th>\r\n        <th>질문</th>\r\n        <th>만족여부</th>\r\n      </tr>\r\n");
#nullable restore
#line 110 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
       foreach (Rule rule in Model.Item3)
      {
        if (5 < Convert.ToInt32(@rule.sequenceNumber) && Convert.ToInt32(@rule.sequenceNumber) < 32)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("          <tr>\r\n            <td>");
#nullable restore
#line 115 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
           Write(rule.sequenceNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 116 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
           Write(rule.type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 117 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
           Write(rule.question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 119 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
               if (Convert.ToInt32(@rule.sequenceNumber) > 5)
              {
                if (@rule.isPassed)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                  <center>O</center>\r\n");
#nullable restore
#line 124 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
                  passedRule += 1;
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                  <center><b>X</b></center>\r\n");
#nullable restore
#line 129 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
                }
              }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </td>\r\n          </tr>\r\n");
#nullable restore
#line 133 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
        }
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    <hr />\r\n    <table cellpadding=\"0\" cellspacing=\"0\" border=\"1\">\r\n      <tr>\r\n        <th>졸업가능여부</th>\r\n        <th>만족조건/전체조건</th>\r\n      </tr>\r\n      <tr>\r\n        <td>\r\n          <center>\r\n");
#nullable restore
#line 145 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
             if (passedRule < 26)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("              <b>Fail</b>\r\n");
#nullable restore
#line 148 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("              <b>Pass</b>\r\n");
#nullable restore
#line 152 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("          </center>\r\n        </td>\r\n\r\n        <td>");
#nullable restore
#line 156 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
       Write(passedRule);

#line default
#line hidden
#nullable disable
                WriteLiteral(" / 26</td>\r\n      </tr>\r\n    </table>\r\n");
#nullable restore
#line 159 "D:\repos\GraduationAssesment\TestProject\TestProject\Views\User\userview.cshtml"
  }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<IEnumerable<UserSubject>, UserInfo, List<Rule>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
