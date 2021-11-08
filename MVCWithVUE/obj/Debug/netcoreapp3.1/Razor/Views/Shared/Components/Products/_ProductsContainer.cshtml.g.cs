#pragma checksum "C:\Users\mzlmg\source\repos\MVCWithVUE\MVCWithVUE\Views\Shared\Components\Products\_ProductsContainer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03420646185e8c4c52c37529d5218dc0cb30594b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Products__ProductsContainer), @"mvc.1.0.view", @"/Views/Shared/Components/Products/_ProductsContainer.cshtml")]
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
#line 1 "C:\Users\mzlmg\source\repos\MVCWithVUE\MVCWithVUE\Views\_ViewImports.cshtml"
using MVCWithVUE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mzlmg\source\repos\MVCWithVUE\MVCWithVUE\Views\_ViewImports.cshtml"
using MVCWithVUE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03420646185e8c4c52c37529d5218dc0cb30594b", @"/Views/Shared/Components/Products/_ProductsContainer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e69e056ea12699d3334295c05e344372c3fbbd4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Products__ProductsContainer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .product-list {
        margin-top: 20px;
        display: grid;
        grid-template-columns: repeat(5, 1fr);
    }

    .product-container {
    }
</style>
<script type=""text/javascript"">
    Vue.component('vue-product-container', {
        props: {

        },
        data: function () {
            return {
                tempProducts: [
                    { id: 1, brand: 1, name: 'Bonservis Özel Dana Burger (Ort.45 gr/ad)6,5 Kilogram (45 Gram / Adet)', price: '405,40', img: 'https://www.bonservis.com.tr/bonservis-ozel-dana-burger-ort45-grad-dana-kofte-bonservis-65-kilogram-45-gram-adet-2708-25-K.jpg' },
                    { id: 2, brand: 1, name: 'Bonservis Dana Sucuk Dilimli400 Gram', price: '32,40', img: 'https://www.bonservis.com.tr/bonservis-dana-sucuk-dilimli-5106-sucuk-bonservis-400-gram-5615-51-K.jpg' },
                    { id: 3, brand: 2, name: 'Feast Dondurulmuş Combo Klasik800 Gram', price: '34,40', img: 'https://www.bonservis.com.tr/feast-dondurulmus-comb");
            WriteLiteral(@"o-klasik-kaplamali-urunler-feast-800-gram-5634-49-K.png' }
                ],
                brands: [
                    { name: 'Markalar', id: 0 },
                    { name: 'Bonservis', id: 1 },
                    { name: 'Feast', id: 2 }
                ],
                products: [
                ]
            }
        },
        methods: {
            filter: function (brandId) {
                this.products = this.tempProducts.filter(o => o.brand == brandId || !brandId);
            }
        },
        mounted() {
            this.filter();
        },
        template: '#vue-product-container-template'
    });
</script>
<script type=""text/template"" id=""vue-product-container-template"">
    <div class=""container product-container"">
        <div>
            <div class=""dropdown"">
                <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton1"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                    Kategoriler
   ");
            WriteLiteral(@"             </button>
                <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton1"">
                    <li v-for=""brand in brands"" v-on:click=""filter(brand.id)""><a class=""dropdown-item"" href=""#""> {{ brand.name }} </a></li>
                </ul>
            </div>
        </div>
        <div class=""product-list"">
            <div v-for=""item in products"">
                <vue-product v-bind:id=""item.id"" v-bind:name=""item.name"" v-bind:img=""item.img"" v-bind:price=""item.price"" class=""mb-4"">
                </vue-product>
            </div>
        </div>
    </div>

</script>");
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
