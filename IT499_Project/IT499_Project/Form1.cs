using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT499_Project
{
    public partial class form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        string currentTechID = "";


        public form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            string server = "192.168.1.130";
            string database = "FixedRightWorkOrder";

            string connectionString = @"Data Source= " + server + "; Initial Catalog= " + database + 
                "; User ID= " + username + "; Password= " + password;

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("You have been logged in.");
                loginButton.Enabled = false;
                logoutButton.Enabled = true;
                passwordBox.Clear();

                if (username.Contains("agent"))
                {
                    previousButton.Enabled = true;
                    nextButton.Enabled = true;
                    customerBox.Enabled = true;
                    addressBox.Enabled = true;
                    agentBox.Enabled = true;
                    technicianBox.Enabled = true;
                    ratingBox.Enabled = true;
                    addButton.Enabled = true;
                    updateButton.Enabled = true;
                    deleteButton.Enabled = true;
                    newCustomerButton.Enabled = true;
                    selectButton.Enabled = true;
                    workOrderBox.Enabled = true;
                }

                if (username.Contains("tech"))
                {
                    startDateBox.Enabled = true;
                    estimatedTimeBox.Enabled = true;
                    detailsBox.Enabled = true;
                    followupDateBox.Enabled = true;
                    followupDetailsBox.Enabled = true;
                    resolutionBox.Enabled = true;
                    actualTimeBox.Enabled = true;
                    updateButton.Enabled = true;
                    selectButton.Enabled = true;
                    workOrderBox.Enabled = true;

                    currentTechID = usernameBox.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Logging In.");
                connection.Close();
            } 
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                MessageBox.Show("You have been logged out.");
                loginButton.Enabled = true;
                logoutButton.Enabled = false;
                usernameBox.Clear();

                workOrderBox.Enabled = false;
                previousButton.Enabled = false;
                nextButton.Enabled = false;
                customerBox.Enabled = false;
                addressBox.Enabled = false;
                agentBox.Enabled = false;
                technicianBox.Enabled = false;
                ratingBox.Enabled = false;
                addButton.Enabled = false;
                deleteButton.Enabled = false;
                startDateBox.Enabled = false;
                estimateCostBox.Enabled = false;
                estimatedTimeBox.Enabled = false;
                detailsBox.Enabled = false;
                followupDateBox.Enabled = false;
                followupDetailsBox.Enabled = false;
                resolutionBox.Enabled = false;
                actualCostBox.Enabled = false;
                actualTimeBox.Enabled = false;
                updateButton.Enabled = false;
                selectButton.Enabled = false;
                newCustomerButton.Enabled = false;
                ratingBox.Enabled = false;

                workOrderBox.Clear();
                customerBox.Clear();
                addressBox.Clear();
                agentBox.Clear();
                technicianBox.Clear();
                rateBox.Clear();
                estimateCostBox.Clear();
                estimatedTimeBox.Clear();
                actualCostBox.Clear();
                actualTimeBox.Clear();
                followupDateBox.Clear();
                ratingBox.Clear();
                detailsBox.Clear();
                resolutionBox.Clear();
                followupDetailsBox.Clear();
                startDateBox.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("UNKNOWN ERROR! You have not been logged out!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string workOrder = workOrderBox.Text;

            string customer = customerBox.Text;
            string[] customerName = customer.Split(' ');

            string fullAddress = addressBox.Text;
            string[] address = fullAddress.Split (',');

            string agent = agentBox.Text;
            string[] agentName = agent.Split(' ');
            
            string tech = technicianBox.Text;
            string[] techName = tech.Split(' ');


            double rate = 0;
            string startDate = "2000-01-01";
            double estimatedTime = 0;
            double actualTime = 0;
            double estimatedCost = 0;
            double actualCost = 0;
            string followupDate = "2000-01-01";
            int rating = 0;


            if (rateBox.Text != "")
            {
                rate = Convert.ToDouble(rateBox.Text);
            }
            if (startDateBox.Text != "")
            {
                startDate = startDateBox.Text;
            }
            if(followupDateBox.Text != "")
            {
                followupDate = followupDateBox.Text;
            }
            if (estimatedTimeBox.Text != "")
            {
                estimatedTime = Convert.ToDouble(estimatedTimeBox.Text);
            }
            if (actualTimeBox.Text != "")
            {
                actualTime = Convert.ToDouble(actualTimeBox.Text);
            }


            estimatedCost = calculateCost(rate, estimatedTime);
            actualCost = calculateCost(rate, actualTime);


            if (ratingBox.Text != "")
            {
                rating = Convert.ToInt32(ratingBox.Text);
            }


            string details = detailsBox.Text;
            string followupDetails = followupDetailsBox.Text;
            string resolution = resolutionBox.Text;

            string customerID = IDLookup("Customer");
            string agentID = IDLookup("Agent");
            string techID = IDLookup("Tech");

            string sqlString = "";

            if (currentTechID.Contains("tech"))
                sqlString = "SELECT * FROM OrderTable WHERE OrderID = " + workOrder + " AND TechID = '" + currentTechID + "';";
            else
                sqlString = "SELECT * FROM OrderTable WHERE OrderID = " + workOrder;
            command = new SqlCommand(sqlString, connection);


            reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("This work order does not exist");
                reader.Close();
                command.Dispose();
                return;
            }
            reader.Close();
            command.Dispose();


            if (!isNameValid("Customer", customer))
                return;
            if (!isNameValid("Agent", agent))
                return;
            if (!isNameValid("Tech", tech))
                return;


            if (address.Length == 4)
            {
                string address1 = address[0];
                string city = address[1].Substring(1);
                string state = address[2].Substring(1);
                string zipcode = address[3].Substring(1);


                sqlString = "UPDATE CustomerTable SET CustomerAddress1 = '" + address1 +
                     "', CustomerCity = '" + city +
                     "', CustomerState = '" + state +
                     "', CustomerZipCode = '" + zipcode +
                     "' WHERE CustomerFirst = '" + customerName[0] + "' AND CustomerLast = '" + customerName[1] + "';";
                command = new SqlCommand(sqlString, connection);
                reader = command.ExecuteReader();
                reader.Close();
                command.Dispose();

            }
            else if (address.Length == 5)
            {
                string address1 = address[0];
                string address2 = address[1].Substring(1);
                string city = address[2].Substring(1);
                string state = address[3].Substring(1);
                string zipcode = address[4].Substring(1);


                sqlString = "UPDATE CustomerTable SET CustomerAddress1 = '" + address1 +
                     "', CustomerAddress2 = '" + address2 +
                     "', CustomerCity = '" + city +
                     "', CustomerState = '" + state +
                     "', CustomerZipCode = '" + zipcode +
                     "' WHERE CustomerFirst = '" + customerName[0] + "' AND CustomerLast = '" + customerName[1] + "';";

                command = new SqlCommand(sqlString, connection);
                reader = command.ExecuteReader();
                reader.Close();
                command.Dispose();
            }
            else
            {
                MessageBox.Show("Please enter address with the following format: \n \"Street, Apartment (if applicable), City, State, Zip\"" );
                return;
            }


            if (!isDateValid(startDate) || !isDateValid(followupDate))
            {
                MessageBox.Show("Please enter dates with the format YYYY-MM-DD");
                return;
            }

            if ((rating > 5 || rating < 1) && usernameBox.Text.Contains("agent"))
            {
                MessageBox.Show("Please enter a rating between 1 and 5.");
                return;
            }
                 
            sqlString = "UPDATE OrderTable SET StartDate = '" + startDate +
                "', FollowupDate = '" + followupDate +
                "', ActualCompletionTime = " + actualTime +
                ", EstimatedCompletionTime = " + estimatedTime +
                ", ActualCost = " + actualCost +
                ", EstimatedCost = " + estimatedCost +
                ", Details = '" + details +
                "', FollowupDetails = '" + followupDetails +
                "', Resolution = '" + resolution +
                "', Rating = " + rating +
                ", TechID = '" + IDLookup("Tech") +
                "' WHERE OrderID = " + workOrder + ";";

            rateBox.Text = rateLookup(IDLookup("Tech"));

            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();
  
            reader.Close();
            command.Dispose();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string agent = agentBox.Text;
            string tech = technicianBox.Text;
            string rating = ratingBox.Text;

            string customerID = IDLookup("Customer");
            string agentID = IDLookup("Agent");
            string techID = IDLookup("Tech");

            workOrderBox.Text = (totalWorkOrders() + 1).ToString();
            string workOrder = workOrderBox.Text;


            string sqlString = "INSERT INTO OrderTable (OrderID, CustomerID, AgentID, TechID) VALUES ('" + workOrder + "', '" + customerID + "', 'agent', '" + techID + "');";
            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();

            reader.Close();
            command.Dispose();

            rateBox.Text = rateLookup(techID);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string sqlString = "DELETE FROM OrderTable WHERE OrderID = " + workOrderBox.Text;
            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();

            reader.Close();
            command.Dispose();
            MessageBox.Show("Work order has been deleted.");
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int current = Convert.ToInt32(workOrderBox.Text);
            int newOrder = current + 1;

            if (newOrder <= totalWorkOrders())
            {
                string sqlString = "SELECT * FROM OrderTable WHERE OrderID = " + newOrder;
                command = new SqlCommand(sqlString, connection);
                reader = command.ExecuteReader();

                string customerID = "", agentID = "", techID = "";
                
                while (reader.Read())
                {
                    startDateBox.Text = reader.GetValue(4).ToString();
                    followupDateBox.Text = reader.GetValue(5).ToString();
                    actualTimeBox.Text = reader.GetValue(6).ToString();
                    estimatedTimeBox.Text = reader.GetValue(7).ToString();
                    actualCostBox.Text = reader.GetValue(8).ToString();
                    estimateCostBox.Text = reader.GetValue(9).ToString();
                    detailsBox.Text = reader.GetValue(10).ToString();
                    followupDetailsBox.Text = reader.GetValue(11).ToString();
                    resolutionBox.Text = reader.GetValue(12).ToString();
                    ratingBox.Text = reader.GetValue(13).ToString();

                    workOrderBox.Text = reader.GetValue(0).ToString();
                    customerID = reader.GetValue(1).ToString();
                    agentID = reader.GetValue(2).ToString();
                    techID = reader.GetValue(3).ToString();
                }

                reader.Close();
                command.Dispose();

                addressLookup(customerID);

                rateBox.Text = rateLookup(IDLookup("Tech"));

                customerBox.Text = nameConcat(nameLookup(customerID, "Customer")[0], nameLookup(customerID, "Customer")[1]);
                agentBox.Text = nameConcat(nameLookup(customerID, "Agent")[0], nameLookup(customerID, "Agent")[1]);
                technicianBox.Text = nameConcat(nameLookup(customerID, "Tech")[0], nameLookup(customerID, "Tech")[1]);
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            int current = Convert.ToInt32(workOrderBox.Text);
            int newOrder = current - 1;

            if (newOrder > 0)
            {
                string sqlString = "SELECT * FROM OrderTable WHERE OrderID = " + newOrder;
                command = new SqlCommand(sqlString, connection);
                reader = command.ExecuteReader();

                string customerID = "", agentID = "", techID = "";
                
                while (reader.Read())
                {
                    startDateBox.Text = reader.GetValue(4).ToString();
                    followupDateBox.Text = reader.GetValue(5).ToString();
                    actualTimeBox.Text = reader.GetValue(6).ToString();
                    estimatedTimeBox.Text = reader.GetValue(7).ToString();
                    actualCostBox.Text = reader.GetValue(8).ToString();
                    estimateCostBox.Text = reader.GetValue(9).ToString();
                    detailsBox.Text = reader.GetValue(10).ToString();
                    followupDetailsBox.Text = reader.GetValue(11).ToString();
                    resolutionBox.Text = reader.GetValue(12).ToString();
                    ratingBox.Text = reader.GetValue(13).ToString();

                    workOrderBox.Text = reader.GetValue(0).ToString();
                    customerID = reader.GetValue(1).ToString();
                    agentID = reader.GetValue(2).ToString();
                    techID = reader.GetValue(3).ToString();
                }

                reader.Close();
                command.Dispose();


                addressLookup(customerID);

                rateBox.Text = rateLookup(IDLookup("Tech"));

                customerBox.Text = nameLookup(customerID, "Customer")[0] + " " + nameLookup(customerID, "Customer")[1];
                agentBox.Text = nameLookup(agentID, "Agent")[0] + " " + nameLookup(agentID, "Agent")[1];
                technicianBox.Text = nameLookup(techID, "Tech")[0] + " " + nameLookup(techID, "Tech")[1];
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            string sqlString = "";

            customerBox.Clear();
            addressBox.Clear();
            agentBox.Clear();
            technicianBox.Clear();
            rateBox.Clear();
            estimateCostBox.Clear();
            estimatedTimeBox.Clear();
            actualCostBox.Clear();
            actualTimeBox.Clear();
            followupDateBox.Clear();
            ratingBox.Clear();
            detailsBox.Clear();
            resolutionBox.Clear();
            followupDetailsBox.Clear();
            startDateBox.Clear();


            if (currentTechID.Contains("tech"))
                sqlString = "SELECT * FROM OrderTable WHERE OrderID = " + workOrderBox.Text + " AND TechID = '" + currentTechID + "';";
            else
                sqlString = "SELECT * FROM OrderTable WHERE OrderID = " + workOrderBox.Text;


            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();

            string customerID = "", agentID = "", techID = "";

            DateTime tempDate;
            
            while (reader.Read())
            {
                if (reader.GetValue(4) == DBNull.Value)
                {
                    startDateBox.Text = reader.GetValue(4).ToString();
                }
                else
                {
                    tempDate = reader.GetDateTime(4);
                    startDateBox.Text = tempDate.ToString("yyyy-MM-dd");
                }

                if (reader.GetValue(5) == DBNull.Value)
                {
                    followupDateBox.Text = reader.GetValue(5).ToString();
                }
                else
                {
                    tempDate = reader.GetDateTime(5);
                    followupDateBox.Text = tempDate.ToString("yyyy-MM-dd");
                }
                actualTimeBox.Text = reader.GetValue(6).ToString();
                estimatedTimeBox.Text = reader.GetValue(7).ToString();
                actualCostBox.Text = reader.GetValue(8).ToString();
                estimateCostBox.Text = reader.GetValue(9).ToString();
                detailsBox.Text = reader.GetValue(10).ToString();
                followupDetailsBox.Text = reader.GetValue(11).ToString();
                resolutionBox.Text = reader.GetValue(12).ToString();
                ratingBox.Text = reader.GetValue(13).ToString();

                customerID = reader.GetValue(1).ToString();
                agentID = reader.GetValue(2).ToString();
                techID = reader.GetValue(3).ToString();
            }

            reader.Close();
            command.Dispose();

            addressLookup(customerID);

            sqlString = "SELECT Rate FROM TechTable WHERE TechID = '" + techID + "';";
            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();

            double payRate = 0;

            while (reader.Read())
            {
                payRate = Convert.ToDouble(reader.GetValue(0));
                reader.NextResult();
            }

            reader.Close();
            command.Dispose();

            rateBox.Text = payRate.ToString();

            customerBox.Text = nameLookup(customerID, "Customer")[0] + " " + nameLookup(customerID, "Customer")[1];
            agentBox.Text = nameLookup(agentID, "Agent")[0] + " " + nameLookup(agentID, "Agent")[1];
            technicianBox.Text = nameLookup(techID, "Tech")[0] + " " + nameLookup(techID, "Tech")[1];
        }

        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            string customer = customerBox.Text;
            string [] customerName = customer.Split(' ');

            string fullAddress = addressBox.Text;
            string[] address = fullAddress.Split(',');

            if (!isNameValid("Customer", customer))
                return;

            string sqlString = "SELECT CustomerID FROM CustomerTable WHERE CustomerFirst='" + customerName[0] + "' AND CustomerLast ='" + customerName[1] + "';";
            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();


            if (reader.HasRows)
            {

                MessageBox.Show("Customer already in database.");
                reader.Close();
                command.Dispose();
                return;
            }

            reader.Close();
            command.Dispose();

            string custID = customerName[1].Substring(0, 4) + "00" + customerName[0].Substring(0, 4);

            sqlString = "INSERT INTO CustomerTable (CustomerID, CustomerFirst, CustomerLast)" +
                "VALUES ('" + custID + "', '" + customerName[0] + "', '" + customerName[1] + "');";

            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();
            reader.Close();
            command.Dispose();

            if (address.Length == 4)
            {
                string address1 = address[0];
                string city = address[1].Substring(1);
                string state = address[2].Substring(1);
                string zipcode = address[3].Substring(1);


                sqlString = "UPDATE CustomerTable SET CustomerAddress1 = '" + address1 +
                     "', CustomerCity = '" + city +
                     "', CustomerState = '" + state +
                     "', CustomerZipCode = '" + zipcode +
                     "' WHERE CustomerFirst = '" + customerName[0] + "' AND CustomerLast = '" + customerName[1] + "';";
                command = new SqlCommand(sqlString, connection);
                reader = command.ExecuteReader();
                reader.Close();
                command.Dispose();

            }
            else if (address.Length == 5)
            {
                string address1 = address[0];
                string address2 = address[1].Substring(1);
                string city = address[2].Substring(1);
                string state = address[3].Substring(1);
                string zipcode = address[4].Substring(1);


                sqlString = "UPDATE CustomerTable SET CustomerAddress1 = '" + address1 +
                     "', CustomerAddress2 = '" + address2 +
                     "', CustomerCity = '" + city +
                     "', CustomerState = '" + state +
                     "', CustomerZipCode = '" + zipcode +
                     "' WHERE CustomerFirst = '" + customerName[0] + "' AND CustomerLast = '" + customerName[1] + "';";

                command = new SqlCommand(sqlString, connection);
                reader = command.ExecuteReader();
                reader.Close();
                command.Dispose();
            }
            else
            {
                MessageBox.Show("Please enter address with the following format: \n \"Street, Apartment (if applicable), City, State, Zip\"");
                return;
            }



            MessageBox.Show("Customer has been added.");

            reader.Close();
            command.Dispose();
        }

        private string nameConcat (string first, string last)
        {
            return (first + " " + last);
        }


        private string IDLookup(string person)
        {
            string id = "";
            string[] name = new string[2];

            if (person.Equals("Customer"))
                name = customerBox.Text.Split(' ');

            if (person.Equals("Agent"))
                name = agentBox.Text.Split(' ');

            if (person.Equals("Tech"))
                name = technicianBox.Text.Split(' ');

            string sqlString = "SELECT " + person + "ID FROM " + person + "Table WHERE " + person + "First='" + name[0] + "' AND " + person + "Last ='" + name[1] + "';";
            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();

                sqlString = "SELECT " + person + "ID FROM " + person + "Table WHERE " + person + "First='" + name[0] + "' AND " + person + "Last ='" + name[1] + "';";
                command = new SqlCommand(sqlString, connection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetString(0);
                }
                
            }

            command.Dispose();
            reader.Close();
            return id;
        }

        private string[] nameLookup(string id, string person)
        {
            string[] name = new string[2];

            string sqlString = "SELECT " + person + "First, " + person + "Last FROM " + person + "Table WHERE " + person + "ID='" + id + "';";
            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                name[0] = reader.GetValue(0).ToString();
                name[1] = reader.GetValue(1).ToString();
            }

            reader.Close();
            command.Dispose();

            return name;
        }

        private int totalWorkOrders()
        {
            int total = 0;

            string sqlString = "SELECT count(*) FROM OrderTable;";
            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();

            if (!reader.HasRows)
                total = 0;
            else
            {
                while (reader.Read())
                {
                    total = reader.GetInt32(0);
                }
            }

            reader.Close();
            command.Dispose();

            return total;
        }

        private string rateLookup(string techID)
        {
            string rate = "";

            string sqlString = "SELECT Rate FROM TechTable WHERE TechID='" + techID + "';";
            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                rate = reader.GetValue(0).ToString();
            }
            command.Dispose();
            reader.Close();

            return rate;
        }

        private double calculateCost (double rate, double time)
        {
            return rate * time;
        }

        private bool isNameValid(string personType, string name)
        {
            switch (personType)
            {
                case "Customer":
                    if (name.Any(c => char.IsDigit(c)) || name.Split(' ').Length != 2)
                    {
                        MessageBox.Show("Please make sure to input a valid first and last name for the Customer.");
                        return false;
                    }
                    break;

                case "Agent":
                    if (name.Any(c => char.IsDigit(c)) || name.Split(' ').Length != 2)
                    {
                        MessageBox.Show("Please make sure to input a valid first and last name for the Agent.");
                        return false;
                    }
                    break;

                case "Tech":
                    if (name.Any(c => char.IsDigit(c)) || name.Split(' ').Length != 2)
                    {
                        MessageBox.Show("Please make sure to input a valid first and last name for the Technician.");
                        return false;
                    }
                    break;

                default:
                    MessageBox.Show("Internal Error.");
                    return false;
            }

            return true;
        }

        private bool isDateValid(string date)
        {
            string[] dateArray = date.Split('-');

            if (dateArray[0].Length != 4)
            {
                return false;
            }

            if (dateArray[1].Length != 2 || Int32.Parse(dateArray[1]) > 12)
            {
                return false;
            }

            if (dateArray[2].Length != 2 || Int32.Parse(dateArray[2]) > 31)
            {
                return false;
            }

            return true;

        }

        private void addressLookup(string customerID)
        {
            string sqlString = "SELECT * FROM CustomerTable WHERE CustomerID = '" + customerID + "';";
            command = new SqlCommand(sqlString, connection);
            reader = command.ExecuteReader();

            string fullAddress = "";

            while (reader.Read())
            {
                if (reader.GetValue(3) != DBNull.Value)
                {
                    fullAddress += reader.GetValue(3).ToString() + ", ";
                }
                if (reader.GetValue(4) != DBNull.Value)
                {
                    fullAddress += reader.GetValue(4).ToString() + ", ";

                    if (reader.GetValue(5) != DBNull.Value)
                    {
                        fullAddress += reader.GetValue(5).ToString() + ", ";
                    }
                    if (reader.GetValue(6) != DBNull.Value)
                    {
                        fullAddress += reader.GetValue(6).ToString() + ", ";
                    }
                    if (reader.GetValue(7) != DBNull.Value)
                    {
                        fullAddress += reader.GetValue(7).ToString();
                    }
                }
                else
                {
                    if (reader.GetValue(5) != DBNull.Value)
                    {
                        fullAddress += reader.GetValue(5).ToString() + ", ";
                    }
                    if (reader.GetValue(6) != DBNull.Value)
                    {
                        fullAddress += reader.GetValue(6).ToString() + ", ";
                    }
                    if (reader.GetValue(7) != DBNull.Value)
                    {
                        fullAddress += reader.GetValue(7).ToString();
                    }
                }

            }

            reader.Close();
            command.Dispose();

            addressBox.Text = fullAddress;
        }
    }
}
