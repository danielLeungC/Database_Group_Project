using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Database_Group_Project
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {

        int satisfy_score = 30;
        int budget_score = 1000;
        int team_avail = 10;
        int customer = 0;
        int merchant = 10;
        int question_id = 1;
        FlowDocument ques_FlowDoc = new FlowDocument();
        Paragraph paragrah = new Paragraph();
        DispatcherTimer timer;
        TimeSpan time;


        public MainWindow()
        {
            InitializeComponent();
           

            // Set the initial label values 
            satisf_val_label.Content = satisfy_score.ToString();
            budget_val_label.Content = budget_score.ToString();
            team_avali_val_label.Content = team_avail.ToString();
            customer_val_label.Content = customer.ToString();
            merchant_val_label.Content = merchant.ToString();


            //Set Timer
            time = TimeSpan.FromMinutes(2);

            timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                time_val_label.Content = time.ToString("c");
                if (time == TimeSpan.Zero) 
                {
                    time = time.Add(TimeSpan.FromMinutes(2));
                    reduceCost(100);
                }
                time = time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            timer.Start();


            //Development Stage
            //Question 1. Add the new features of Registration
            //           You need to determine using which method to protect the data, if you encrypted all data, you cannot directly apply to other feature at the futher development.


            paragrah.Inlines.Add(new Run("I am a flow document. Would you like to edit me? "));
            paragrah.Inlines.Add(new Bold(new Run("Go ahead.")));
            ques_FlowDoc.Blocks.Add(paragrah);
            question_area.Document = ques_FlowDoc;




            // Insert the default database in the database list.
            List<Database> items = new List<Database>();
            // Construct the Database which related to the 
            items.Add(new Database() { name = "Database 1", spec = "Oracle Database 18c", version = "18.3.2", purpose= "Employee Information", haveReplicate=true,condition= "Normal" });
            listview_db.ItemsSource = items;


        }


        private void getNextQuestion() 
        {
            //Development Stage

            //Question 2. Add the new feature of "Order Processing" -> Must be related to the PCI or data privacy standard (Lecture 1)

            //Question 3. Add the new feature of "Order Tracking" -> May related to the data redaction and data masking

            //Question 4. Add the new feature of "Food Recommendation" 

            //Question 5. Add the new feature of "Order Review"

            //Question 6. Add the new feature of "Rating System"

            //Production Stage
            //Question 7. Detect the internal attack (Part 1) -> Select the situation option in order to find any internal attacker.

            //Question 8. Detect the internal attack (Part 2) -> How to handle the internal attacker. (e.g. change permission, change password, etc)

            //Question 9. Issue the oracle database voluneriabilities. (Which might not be directly affect our business)

            //Question 10. Issue the oracle databbase volurnierability by third-party (Which significanty affect our system.)

            //Question 11. Data Breach (First Step) -> Find the reason

            //Question 12. Data Breach (Secon Step) -> isoluate the affected database

            //Question 13. Data Breach (Third Step)

            //Question 14. Administrator departure





        }


        private void reduceCost(int cost) 
        {
            budget_score = budget_score - cost;
            budget_val_label.Content = budget_score.ToString();
        }


        private string verifyQuestionAns() 
        {



            return "";
        }

        private int getSelectCheckboxNum() {
            return 0;
        }



        private void listview_db_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void confirm_button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
