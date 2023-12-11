using System;

namespace Practice12
{
    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);

    public class PropertyEventArgs : EventArgs
    {
        public string PropertyName { get; }

        public PropertyEventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }

    public interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }

    public class Human : IPropertyChanged
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public event PropertyEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyEventArgs(propertyName));
        }
    }

    class Program
    {
        static void Main()
        {
            Human myObject = new Human();
            myObject.PropertyChanged += HandlePropertyChanged;
            myObject.Name = "Martin";
        }

        static void HandlePropertyChanged(object sender, PropertyEventArgs e)
        {
            Console.WriteLine($"Property {e.PropertyName} changed.");
        }
    }
}
