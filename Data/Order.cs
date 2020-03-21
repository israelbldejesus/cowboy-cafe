using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        public double Subtotal => 0;

        public void Add(IOrderItem Item) 
        {
            if(Item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            Items.Add(Item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem Item) 
        {
            if(Item is INotifyPropertyChanged notifier){
                notifier.PropertyChanged -= OnItemPropertyChanged;

            }
            items.Remove(Item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnItemPropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}