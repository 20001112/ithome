using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ithomework
{
    public partial class Frm_Pos : Form
    {
        public Frm_Pos()
        {
            InitializeComponent();
        }
        int Beer = 0;
        int Tequila = 0;
        int Whisky = 0;
        int Wine = 0;

        private void Btn_beer_Click(object sender, EventArgs e)
        {
            Beer += 1;
            UpdateShoppingList();
        }

        private void Btn_Tequila_Click(object sender, EventArgs e)
        {
            Tequila += 1;
            UpdateShoppingList();
        }
        private void btn_Wine_Click_1(object sender, EventArgs e)
        {
            Wine += 1;
            UpdateShoppingList();
        }

        private void Btn_Winsky_Click_1(object sender, EventArgs e)
        {
            Whisky += 1;
            UpdateShoppingList();
        }



        private void UpdateShoppingList()
        {
            int BeerTotalQuantity = Beer;
            int TequilaTotalQuantity = Tequila;
            int WhiskyTotalQuantity = Whisky;
            int WineTotalQuantity = Wine;

            int BeerTotalPrice = BeerTotalQuantity * 120;
            int TequilaTotalPrice = TequilaTotalQuantity * 180;
            int WhiskyTotalPrice = WhiskyTotalQuantity * 350;
            int WineTotalPrice = WineTotalQuantity * 320;

            int TotalPrice = BeerTotalPrice + TequilaTotalPrice + WhiskyTotalPrice + WineTotalPrice;

            string shoppingListText = string.Empty;

            if (BeerTotalQuantity > 0)
            {
                shoppingListText += "啤酒 Beer X " + BeerTotalQuantity + " 共 NT$" + BeerTotalPrice.ToString() + "元" + Environment.NewLine;
            }

            if (TequilaTotalQuantity > 0)
            {
                shoppingListText += "龍舌蘭 Tequila X " + TequilaTotalQuantity + " 共 NT$" + TequilaTotalPrice.ToString() + "元" + Environment.NewLine;
            }

            if (WhiskyTotalQuantity > 0)
            {
                shoppingListText += "威士忌 Whisky X " + WhiskyTotalQuantity + " 共 NT$" + WhiskyTotalPrice.ToString() + "元" + Environment.NewLine;
            }

            if (WineTotalQuantity > 0)
            {
                shoppingListText += "紅酒 Wine X " + WineTotalQuantity + " 共 NT$" + WineTotalPrice.ToString() + "元" + Environment.NewLine;
            }

            Lab_list.Text = shoppingListText;
            Lab_TotalPrice.Text = "總金額: NT$" + TotalPrice.ToString();
        }

        private void Btn_Cash_Click(object sender, EventArgs e)
        {
            int TotalPrice = GetTotalPrice();

            if (TotalPrice==0)
            {
                MessageBox.Show("尚未點餐");
             
            }
            else

            MessageBox.Show("總金額: NT$" + TotalPrice.ToString());
            



        }

        private void Btn_Card_Click(object sender, EventArgs e)
        {
            int TotalPrice = GetTotalPrice();
            int discountedPrice = (int)Math.Round(TotalPrice * 0.9); // 打九折

            if (TotalPrice==0)
            {
                MessageBox.Show("尚未點餐");

            }
            else

            MessageBox.Show("總金額:NT"+TotalPrice+"\n"+
                "總金額(打九折後): NT$" + discountedPrice.ToString());

        }
        private int GetTotalPrice()
        {
            int BeerTotalQuantity = Beer;
            int TequilaTotalQuantity = Tequila;
            int WhiskyTotalQuantity = Whisky;
            int WineTotalQuantity = Wine;

            int BeerTotalPrice = BeerTotalQuantity * 120;
            int TequilaTotalPrice = TequilaTotalQuantity * 180;
            int WhiskyTotalPrice = WhiskyTotalQuantity * 350;
            int WineTotalPrice = WineTotalQuantity * 320;

            int TotalPrice = BeerTotalPrice + TequilaTotalPrice + WhiskyTotalPrice + WineTotalPrice;

            return TotalPrice;
        }

        private void Btn_List_Click(object sender, EventArgs e)
        {
            Beer = 0;
            Tequila = 0;
            Whisky = 0;
            Wine = 0;

            Lab_list.Text = string.Empty;
            Lab_TotalPrice.Text = string.Empty;

        }
    }
}
