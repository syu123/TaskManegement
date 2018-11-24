using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace TaskManagement
{
    public partial class Form1 : Form
    {
        // XMLの保存先
        string fileName = @"C:\Temp\task.xml";
        List<Task> taskList;


        public Form1()
        {
            InitializeComponent();
            InitControlProperty();
            Init();

        }

        private void InitControlProperty()
        {
            // 画面に表示される要素を指定
            listBox.DisplayMember = "Name";
        }

        private void Init()
        {
            // データの読み込み
           loadData();
            // バインディング
            // バインドするものを変える
            taskBindingSource.DataSource = listBox.SelectedItem;
        }

        private void loadData()
        {
            // 保存されているデータを読み込む
            XmlSerializer serializer = new XmlSerializer(typeof(List<Task>));
            StreamReader sr = new StreamReader(fileName, new System.Text.UTF8Encoding(false));
            taskList = (List<Task>)serializer.Deserialize(sr);

            // 新規追加用のタスクを先頭に追加
            taskList.Insert(0, createBaseTask());

            //　本日日付のデータをlistに表示する
            listBox.DataSource = taskList;

        }

        private Task createBaseTask()
        {
            Task task = new Task();
            task.Name = "(新規に追加)";
            return task;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateXMLData();
        }

        private void CreateXMLData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Task>));

            //            Task task = (Task)taskBindingSource.DataSource;
            Task task = new Task();
            task.Name = taskName.Text;
            task.PlannedTime = taskPlannedTime.Text;
            task.Type = taskType.Text;
            task.Details = taskDetail.Text;
            task.Date = DateTime.Now;
            
            // 書き込むファイルを開く（UTF-8、BOM無し）
            StreamWriter sw = new StreamWriter(fileName, false, new System.Text.UTF8Encoding(false));

            var tasklist = new List<Task>();
            tasklist.Add(task);

            // シリアル化
            serializer.Serialize(sw, tasklist);

            sw.Close();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            taskBindingSource.DataSource = listBox.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox.SelectedIndex == 0)
            {
                Task task = new Task();
                task.Name = taskName.Text;
                task.PlannedTime = taskPlannedTime.Text;
                task.Type = taskType.Text;
                task.Details = taskDetail.Text;
                task.Date = DateTime.Now;
                taskList.Add(task);
                listBox.SelectedIndex = 0;
                listBox.DataSource = taskList;
                // list では変更通知ができなく画面の更新がされない。
            }
        }
    }
}
