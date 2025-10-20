using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project
{

    public class clsPizzaOrder
    {
        // ====== الخصائص الأساسية ======
        public string Size { get; set; } = "Medium";
        public string CrustType { get; set; } = "Thin Crust";
        public List<string> Toppings { get; set; } = new List<string>();
        public string WhereToEat { get; set; } = "Eat In";

        // ====== الأسعار (يمكن جعلها قابلة للتعديل من ملف config لاحقًا) ======
        private readonly Dictionary<string, float> SizePrices = new Dictionary<string, float> {
            {"Small", 20f },
            { "Medium", 35f },
            { "Large", 50f }
            };

        private readonly Dictionary<string, float> CrustPrices =new Dictionary<string, float>()
        {
            { "Thin Crust", 5f },
            { "Think Crust", 10f }
        };

        private readonly Dictionary<string, float> ToppingPrices =new Dictionary<string, float>()
        {
            { "Extra Chees", 5f },
            { "Onion", 3f },
            { "Mushrooms", 4f },
            { "Olives", 4f },
            { "Tomatoes", 2f },
            { "GreenPeppers", 3f }
        };
    }
}
