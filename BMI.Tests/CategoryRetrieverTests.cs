using System;
using System.Linq;
using Bmi.Implementations;
using Xunit;
using Bmi.Models;

namespace Bmi.Tests
{
    public class CategoryRetrieverTests
    {
        [Fact]
        public void CategoryRetriever_Throws_ArgumentException_If_Bmi_Is_Less_Than_Zero()
        {
            var categoryRetriever = new CategoryRetriever();
            Assert.Throws<ArgumentException>(() => categoryRetriever.GetWeightCategory(-5));
        }

        [Fact]
        public void CategoryRetriever_DoesNot_Throw_ArgumentException_If_Bmi_Is_More_Than_Zero()
        {
            var categoryRetriever = new CategoryRetriever();
            Assert.DoesNotThrow(() => categoryRetriever.GetWeightCategory(5));
        }

        [Fact]
        public void CategoryRetriever_Returns_UnderWeight_If_Bmi_Is_Less_Than_185()
        {
            var categoryRetriever = new CategoryRetriever();
            WeightCategory category = categoryRetriever.GetWeightCategory(10);
            Assert.Equal(WeightCategory.UnderWeight, category);
        }

        [Fact]
        public void CategoryRetriever_Returns_NormalWeight_If_Bmi_Is_Exactly_185()
        {
            var categoryRetriever = new CategoryRetriever();
            WeightCategory category = categoryRetriever.GetWeightCategory(18.5);
            Assert.Equal(WeightCategory.Normal, category);
        }

        [Fact]
        public void CategoryRetriever_Returns_NormalWeight_If_Bmi_Is_Exactly_249()
        {
            var categoryRetriever = new CategoryRetriever();
            WeightCategory category = categoryRetriever.GetWeightCategory(24.9);
            Assert.Equal(WeightCategory.Normal, category);
        }

        [Fact]
        public void CategoryRetriever_Returns_OverWeight_If_Bmi_Is_Exactly_25()
        {
            var categoryRetriever = new CategoryRetriever();
            WeightCategory category = categoryRetriever.GetWeightCategory(25);
            Assert.Equal(WeightCategory.OverWeight, category);
        }

        [Fact]
        public void CategoryRetriever_Returns_OverWeight_If_Bmi_Is_Exactly_299()
        {
            var categoryRetriever = new CategoryRetriever();
            WeightCategory category = categoryRetriever.GetWeightCategory(25);
            Assert.Equal(WeightCategory.OverWeight, category);
        }

        [Fact]
        public void CategoryRetriever_Returns_Obese_If_Bmi_Is_Exactly_30()
        {
            var categoryRetriever = new CategoryRetriever();
            WeightCategory category = categoryRetriever.GetWeightCategory(30);
            Assert.Equal(WeightCategory.Obese, category);
        }

        [Fact]
        public void CategoryRetriever_Returns_Obese_If_Bmi_Is_Morethan_30()
        {
            var categoryRetriever = new CategoryRetriever();
            WeightCategory category = categoryRetriever.GetWeightCategory(55);
            Assert.Equal(WeightCategory.Obese, category);
        }

        [Fact]
        public void CategoryRetriever_String_Throws_Error_For_Bmi_Lessthan_0()
        {
            var categoryRetriever = new CategoryRetriever();
            Assert.Throws<ArgumentException>(() => categoryRetriever.GetWeightCategoryString(-15));
        }

        [Fact]
        public void CategoryRetriever_String_Doesnot_Throw_Error_For_Bmi_Morethan_0()
        {
            var categoryRetriever = new CategoryRetriever();
            Assert.DoesNotThrow(() => categoryRetriever.GetWeightCategoryString(15));
        }
    }
}
