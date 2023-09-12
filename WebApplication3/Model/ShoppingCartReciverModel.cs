namespace WebApplication3.Model.ShoppingCartReciver
{
    public abstract class OptionBase
    {
        public int? type { get; set; }
        public bool requirement { get; set; }
        public int? key { get; set; }
        public string? name { get; set; }
        public string? memo { get; set; }
    }

    public abstract class OptionVauleBase
    {
        public string? valueName { get; set; }
        public string? valueKey { get; set; }
        public int price { get; set; }
        public bool beChoise { get; set; }
        public string? content { get; set; }
        public string? title { get; set; }
        public string? dishKey { get; set; }
        public string? unit { get; set; }
        public string? imgPath { get; set; }
    }

    public class FirstLayerOption : OptionBase
    {
        public List<FirstLayerOptionVaule>? optionVaules { get; set; }
    }

    public class FirstLayerOptionVaule : OptionVauleBase
    {
        public List<SecondLayerOption>? options { get; set; }
    }

    public class SecondLayerOption : OptionBase
    {
    }

    public class SecondLayerOptionVaule : OptionVauleBase
    {
        public List<SecondLayerOption>? options { get; set; }
    }

    public class Product
    {
        public string title { get; set; }
        public string dishKey { get; set; }
        public string unit { get; set; }
        public string imgPath { get; set; }
        public int price { get; set; }
        public bool isCombo { get; set; }
        public List<FirstLayerOption>? options { get; set; }
    }

    public class ShoppingCartReciverModel
    {
        public Product product { get; set; }
        public int quantity { get; set; }
    }
}
