using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using TimeManager.Model;

namespace TimeManager.ViewModel
{
    public class TaskViewModel : BaseViewModel
    {

        private ObservableCollection<TaskModel> taskTabItems = new ObservableCollection<TaskModel>();
        public ObservableCollection<TaskModel> TaskTabItems { get {  return taskTabItems; } set { taskTabItems = value; OnPropertyChanged(); } }

        private TaskModel selectedItem;
        public TaskModel SelectedItem { get { return selectedItem; } set { selectedItem = value; OnPropertyChanged(); } }

        private TaskModel selectedSubItem;
        public TaskModel SelectedSubItem { get { return selectedSubItem; } set { selectedSubItem = value;
                //if (selectedSubItem == null && SelectedItem.Task != null)
                    //{
                    try
                    {
                        //if (selectedSubItem == null && SelectedItem.Task[0] != null)
                        if (selectedSubItem == null && SelectedItem.Task != null)
                            selectedSubItem = TaskTabItems.First(f => f == SelectedItem).Task[0];
                    }
                    catch (Exception)
                    {
                        selectedSubItem = new TaskModel();
                        //return;
                    }
                //selectedSubItem = TaskTabItems.First(f => f == SelectedItem).Task[0];
                //}

                OnPropertyChanged(); } }
       

        ConnectToBase ConnectBase = new ConnectToBase();
        public DataTable dtCategory = new DataTable();
        public DataTable DtCategory { get { return dtCategory; } set { dtCategory = value; OnPropertyChanged(); } }
        public DataTable dtTasks = new DataTable();
        public DataTable DtTasks { get { return dtTasks; } set { dtTasks = value; OnPropertyChanged(); } }


        private  bool isVisible = false;
        public  bool IsVisible { get { return isVisible; } set { isVisible = value; OnPropertyChanged(); } }

        public TaskViewModel()
        {
            #region TaskTabItems
            //Tasks = new ObservableCollection<TaskModel>(TaskModel.GetTasks());

            //TaskTabItems.Add(new TaskModel() { CategoryName = "Завдання", ID =1 });
            //TaskTabItems.Add(new TaskModel() { CategoryName = "Нагадування", ID = 2 });
            //TaskTabItems.Add(new TaskModel() { CategoryName = "Нотатки", ID = 3});
            //TaskTabItems.Add(new TaskModel() { CategoryName = "Завершині", ID = 4 });
            #endregion
            #region TaskTabItems.Task
            //TaskTabItems[0].Task.Add(new TaskModel() { TaskName = "Завдання 1", TaskBody = "Зробити завдання №1", ID = 0, CreateTime = DateTime.Now, IsFavorite = true, Priority = "high", IsReminder=true });
            //TaskTabItems[0].Task.Add(new TaskModel() { TaskName = "Завдання 2", TaskBody = "Зробити завдання №2", ID = 1, CreateTime = DateTime.Now, IsFavorite = false, Priority = "normal" });
            //TaskTabItems[0].Task.Add(new TaskModel() { TaskName = "Завдання 3", TaskBody = "Зробити завдання №3", ID = 2, CreateTime = DateTime.Now, IsFavorite = false, Priority = "low" });
            //TaskTabItems[1].Task.Add(new TaskModel() { TaskName = "Завдання 4", TaskBody = "Зробити завдання №4", ID = 3, CreateTime = DateTime.Now, IsFavorite = false, Priority = "normal" });
            //TaskTabItems[1].Task.Add(new TaskModel() { TaskName = "Завдання 5", TaskBody = "Зробити завдання №5", ID = 4, CreateTime = DateTime.Now, IsFavorite = false, Priority = "normal" });
            //TaskTabItems[1].Task.Add(new TaskModel() { TaskName = "Завдання 6", TaskBody = "Зробити завдання №6", ID = 5, CreateTime = DateTime.Now, IsFavorite = true, Priority = "high" });
            //TaskTabItems[1].Task.Add(new TaskModel() { TaskName = "Завдання 7", TaskBody = "Зробити завдання №7", ID = 6, CreateTime = DateTime.Now, IsFavorite = false, Priority = "normal" });
            //TaskTabItems[1].Task.Add(new TaskModel() { TaskName = "Завдання 8", TaskBody = "Зробити завдання №8", ID = 7, CreateTime = DateTime.Now, IsFavorite = false, Priority = "low" });
            //TaskTabItems[2].Task.Add(new TaskModel() { TaskName = "Завдання 9", TaskBody = "Зробити завдання №9", ID = 8, CreateTime = DateTime.Now, IsFavorite = true, Priority = "normal" });
            //SelectedIndex = TaskTabItems[0];  // --
            #endregion

            GetCategory();
            GetTasks();

            SelectedItem = TaskTabItems[0];
            SelectedSubItem = TaskTabItems[0].Task[0];
            //timer.Tick += timer_Tick;
            //timer.Interval = new TimeSpan(0, 0, 1);
        }




        public void GetCategory()
        {
            DtCategory = ConnectBase.Select("SELECT * FROM " + ConnectBase.categoryBase);
            for (int i = 0; i < DtCategory.Rows.Count; i++)
            {
                var NewCategory = new TaskModel() { ID = (int)DtCategory.Rows[i]["ID"], CategoryName = DtCategory.Rows[i]["CategoryName"].ToString(), CanDeleted = (bool)DtCategory.Rows[i]["CanDeleted"], CreateTime = (DateTime)DtCategory.Rows[i]["CreateTime"] };
                TaskTabItems.Add(NewCategory);
            }
        }

        public void GetTasks()
        {
            DtTasks = ConnectBase.Select("SELECT * FROM " + ConnectBase.tasksBase);
            //int index, indexC;
            for (int i = 0; i < DtTasks.Rows.Count; i++)
            {
                var cIndex = TaskTabItems.Select((v, index) => new { Index = index, Value = v.ID }) // Pair up values and indexes
                                           .Where(p => p.Value == (int)DtTasks.Rows[i]["Caregory_ID"]) // Do the filtering
                                           .Select(p => p.Index).First(); // Keep the index and drop the value

                var NewTask = new TaskModel() { ID = (int)DtTasks.Rows[i]["ID"], TaskName = DtTasks.Rows[i]["TaskName"].ToString(), TaskBody = DtTasks.Rows[i]["TaskBody"].ToString(),
                    Priority = DtTasks.Rows[i]["Priority"].ToString(), CreateTime = (DateTime)DtTasks.Rows[i]["CreateTime"], IsFavorite = (bool)DtTasks.Rows[i]["IsFavorite"],
                    IsReminder = (bool)DtTasks.Rows[i]["IsReminder"], ReminderTime = DtTasks.Rows[i]["ReminderTime"].ToString() == "" ? DateTime.Now.AddSeconds(-1): (DateTime)DtTasks.Rows[i]["ReminderTime"],
                    IsActive = (bool)DtTasks.Rows[i]["IsActive"]  };   //, IsFavorite = (bool)DtTasks.Rows[i]["IsFavorite"], IsReminder = (bool)DtTasks.Rows[i]["IsReminder"], IsActive = (bool)DtTasks.Rows[i]["IsActive"]  // ReminderTime = (DateTime)DtTasks.Rows[i]["ReminderTime"],

                TaskTabItems[cIndex].Task.Add(NewTask);
            }
        }


    



        public RelayCommand AddCategory_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {

                    TaskTabItems.Add(new TaskModel() { CategoryName = "Notes # " + TaskTabItems.Count + 1 });

                });
            }
        }

        public RelayCommand AddTask_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {
                    foreach (var item in TaskTabItems)
                    {
                        int index = TaskTabItems.IndexOf(item);
                        if (item == SelectedItem)
                            TaskTabItems[index].Task.Add(new TaskModel() { TaskName = "Task " + TaskTabItems[index].Task.Count + 1, TaskBody = "Make a task №" + TaskTabItems[index].Task.Count + 1, ID = TaskTabItems[index].Task.Count + 1 });
                    }



                    //for (int i = 0; i < TaskTabItems.Count; i++)
                    //{
                    //    if (TaskTabItems[i].ID == SelectedItem.ID)
                    //    {
                    //        TaskTabItems[i].Task.Add(new TaskModel() { TaskName = "Завдання " + TaskTabItems[i].Task.Count + 1, TaskBody = "Зробити завдання №" + TaskTabItems[i].Task.Count + 1, ID = TaskTabItems[i].Task.Count + 1 });
                    //        break;
                    //    }
                    //}



                    ////foreach (var item in TaskTabItems)
                    ////{
                    ////    if (item == SelectedItem)
                    ////    {
                    ////        //TaskTabItems[item].Task.Add(new TaskModel() { TaskName = "Завдання " + TaskTabItems[i].Task.Count + 1, TaskBody = "Зробити завдання №" + TaskTabItems[i].Task.Count + 1, ID = TaskTabItems[i].Task.Count + 1 });
                    ////        //break;
                    ////        TaskTabItems[TaskTabItems.IndexOf(item)].Task.Remove(o as TaskModel);
                    ////        //MessageBox.Show("OK");
                    ////    }
                    ////}


                    //TaskTabItems[SelectedItem.ID].Task.Add(new TaskModel() { TaskName = "Завдання 100", TaskBody = "Зробити завдання №100", ID = TaskTabItems[SelectedItem.ID].Task.Count + 1 });


                });
            }
        }

        public RelayCommand RemoveCategory_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {
                    foreach (var item in TaskTabItems)
                    {
                        try
                        {
                            //int index = TaskTabItems.IndexOf(item);
                            if (item.CreateTime == SelectedItem.CreateTime) // +- CreateTime -- ID
                            {
                                TaskTabItems.Remove(o as TaskModel);
                                break;
                            }
                        }
                        catch (Exception)
                        {
                            break;
                            //return;
                        }
                    }
                   
                    //foreach (var item in TaskTabItems)
                    //{
                    //    if (item.ID == SelectedItem.ID)
                    //    {
                    //        TaskTabItems.Remove(item);
                    //        break;
                    //    }
                    //}

                });
            }
        }

        //public RelayCommand RemoveTask_Click  // + -
        //{
        //    get
        //    {
        //        return new RelayCommand((o) =>
        //        {

        //            int indexPerson = SelectedItem.SelectedIndex;

        //            if (indexPerson>=0)
        //            {
        //                for (int i = 0; i < TaskTabItems.Count; i++)
        //                {

        //                    if (TaskTabItems[i].ID == SelectedItem.ID)
        //                    {
        //                        TaskTabItems[i].Task.RemoveAt(indexPerson);
        //                        break;
        //                    }
        //                }
        //            }


        //            //MessageBox.Show(SelectedItem.SelectedIndex.ToString());

        //            //MessageBox.Show("OK");


        //        });
        //    }
        //}

              

        public RelayCommand RemoveTask_Click   //++++++++++++
        {
            get
            {
                return new RelayCommand((o) =>
                {
                    foreach (var item in TaskTabItems)
                    {
                        int index = TaskTabItems.IndexOf(item);
                        if (item == SelectedItem)
                            TaskTabItems[index].Task.Remove(o as TaskModel);                        
                    }

                    ////int indexPerson = SelectedItem.SelectedIndex;

                    ////if (indexPerson >= 0)
                    ////{
                    //for (int i = 0; i < TaskTabItems.Count; i++)
                    //{

                    //    if (TaskTabItems[i].ID == SelectedItem.ID)
                    //    {
                    //        //TaskTabItems[i].Task.RemoveAt(indexPerson);
                    //        TaskTabItems[i].Task.Remove(o as TaskModel);
                    //        break;
                    //    }
                    //}
                    ////}


                    ////TaskTabItems[SelectedItem.ID].Task.Remove(o as TaskModel);


                });   
            }
        }


        public RelayCommand IsFavorite_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {
   

                    foreach (var item in TaskTabItems)
                    {
                        int index = TaskTabItems.IndexOf(item);

                        if (item == SelectedItem)
                        {
                            //TaskTabItems[index].Task.(o as TaskModel);
                            foreach (var task in TaskTabItems[index].Task)
                            {
                                //if (task == SelectedItem)
                                //{

                                    int index2 = TaskTabItems[index].Task.IndexOf(task);
                                    TaskTabItems[index].Task[index2].IsFavorite = !TaskTabItems[index].Task[index2].IsFavorite;
                                //}
                            }
                        }
                    }

                });
            }
        }


        public RelayCommand ReminderActive_Click   //++++++++++++
        {
            get
            {
                return new RelayCommand((o) =>
                {

                    SelectedSubItem.ReminderTime = DateTime.Now.AddSeconds(-1);
                    SelectedSubItem.ChackedHour = DateTime.Now.Hour.ToString();
                    SelectedSubItem.ChackedMinute = DateTime.Now.Minute.ToString();
                   
                });
            }
        }





        public RelayCommand Test_Test_Click 
        {
            get
            {
                return new RelayCommand((o) =>
                {
                    MessageBox.Show("Ok");


                });
            }
        }  // Тільки для тесту !!!!




    }
}
