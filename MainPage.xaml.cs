using System.Collections.ObjectModel;

namespace ToDoList
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> task = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            DateTime currentDate = DateTime.UtcNow;
            collectionTask.ItemsSource = task;
        }

        private void Clicked_AddTask(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(entryUserTask.Text))
            {
                //labelDate.Text = "hi";
                task.Add(entryUserTask.Text);
                //labelDate.Text = entryUserTask.Text;
                entryUserTask.Text = string.Empty;
            }
        }

        private void Clicked_RemoveTask(object sender, EventArgs e)
        {

            
        }
    }
}
