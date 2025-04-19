using System.Windows;

namespace theapp
{
    public partial class MainWindow : Window
    {
        ToDos todos;
        public MainWindow()
        {
            InitializeComponent();
            todos = new ToDos();
            DataContext = todos;
        }

        private void AddTodoButton_clicked(object sender, RoutedEventArgs e)
        {
            ToDo todo = new ToDo()
            {
                desc = NewTodoTextBox.Text
            };
            todos.allTodos.Add(todo);
        }
    }
}