using System.Collections.ObjectModel;

namespace ToDoList
{
    public partial class MainPage : ContentPage
    {
        // Creating Global variables
        private ObservableCollection<string> listOfTask = new ObservableCollection<string>();
        int selectedTaskIndex = 0;

        public MainPage()
        {
            InitializeComponent();
            DateTime currentDate = DateTime.UtcNow;
            collectionTask.ItemsSource = listOfTask;
        }

        private void Clicked_AddTask(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(entryUserTask.Text))
            {
                //labelDate.Text = "hi";
                listOfTask.Add(entryUserTask.Text);
                //labelDate.Text = entryUserTask.Text;
                entryUserTask.Text = string.Empty;
            }
        }

        private void Clicked_RemoveTask(object sender, EventArgs e)
        {

            
        }

        private void collectionTask_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (collectionTask.SelectedItem != null)
            {
                //string selectedTask = collectionTask.SelectedItem.ToString();
                ////selectedTaskIndex = listOfTask.IndexOf(selectedTask);
                //listOfTask.RemoveAt(selectedTaskIndex);
                //buttonAdd.Text = "YIPPEEEE";
            }
            else
            {
            }


        }

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {
            if (sender  is SwipeItem)
            {
                var taskText = collectionTask.SelectedItem.ToString();

                if (taskText != null)
                {
                    listOfTask.Remove(taskText);
                }
                

            }
        }
    }
}
