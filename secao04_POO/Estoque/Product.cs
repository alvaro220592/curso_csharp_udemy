using System;
using System.Globalization;

namespace Estoque{
    class Product{
        public string Name;
        public double Price;
        public int Quantity;

        public void AddProduct(int qtt){
            this.Quantity += qtt;
        }

        public void RemoveProduct(int qtt){
            if(qtt >= this.Quantity){
                this.Quantity = 0;
            }else{
                this.Quantity -= qtt;            
            }
        }

        public double TotalInventoryValue(){
            return this.Quantity * this.Price;
        }

        public override string ToString()
        {
            return $"Produto: {this.Name}, preço unitário: R${this.Price.ToString("F2", CultureInfo.InstalledUICulture)}, qtde. em estoque: {this.Quantity}, valor total: R${this.TotalInventoryValue().ToString("F2", CultureInfo.InstalledUICulture)}";
        }
    }
}