using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theapp
{
    public class ToDos : INotifyPropertyChanged
    {
        public ToDos()
        {
            _allTodos = new ObservableCollection<ToDo>()
            {
                new ToDo() { desc = "Head to the gym" },
                new ToDo() { desc = "Head to the store" },
                new ToDo() { desc = "Head to the clouds" }
            };
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<ToDo> _allTodos;
        public ObservableCollection<ToDo> allTodos
        {
            get { return _allTodos; }
            set
            {
                _allTodos = value;
                OnPropertyChanged(nameof(allTodos));
            }
        }
    }
}
