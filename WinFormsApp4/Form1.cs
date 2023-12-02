using Microsoft.Data.Sqlite;
using System.Data;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        static string connectionString = "Data source=:memory:";
        SqliteConnection connection = new SqliteConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                CreateTable(connection);
                /*Console.WriteLine("Пiдключено до бази даних");
                DisplayAllStorage(connection);
                DisplayAllProducts(connection);
                DisplayAllTypes(connection);
                DisplayAllSuppliers(connection);
                DisplayMaxQuantity(connection);
                DisplayMinQuantity(connection);
                DisplayMaxCostPrice(connection);
                DisplayMinCostPrice(connection);
                DisplayAvgQuantityByType(connection);
                int n;
                Console.Write("Iнформацiя про товар: Введiть iд: ");
                while (!int.TryParse(Console.ReadLine(), out n)) Console.WriteLine("Помилка.");
                DisplayAllInfoOfAProduct(connection, n);
                string a, b;
                Console.Write("Iнформацiя про товар: Введiть тип: ");
                a = Console.ReadLine()!;
                DisplayItemsByType(connection, a);
                Console.Write("Iнформацiя про товар: Введiть постачальника: ");
                b = Console.ReadLine()!;
                DisplayItemsBySupplier(connection, b);
                DisplayOldestItemInStorage(connection);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка пiдключення до бази даних: " + ex.Message);
            }
        }
        public void CreateTable(SqliteConnection connection)
        {
            SqliteCommand c = new SqliteCommand("CREATE TABLE Products (\r\n    ProductId INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    Name TEXT NOT NULL,\r\n    Type TEXT NOT NULL,\r\n    Cost REAL NOT NULL,\r\n    Supplier TEXT NOT NULL\r\n);", connection);
            c.ExecuteNonQuery();
            SqliteCommand c1 = new SqliteCommand("CREATE TABLE Storage (\r\n    StorageId INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    ProductId INTEGER,\r\n    Quantity INTEGER NOT NULL,\r\n    CostPrice REAL NOT NULL,\r\n    SupplyDate DATE NOT NULL,\r\n    FOREIGN KEY (ProductId) REFERENCES Products (ProductId)\r\n);", connection);
            c1.ExecuteNonQueryAsync();

            SqliteCommand ce = new SqliteCommand("INSERT INTO Products(ProductId, Name, Type, Cost, Supplier) VALUES(NULL, 'Яблуко', 'Фрукт', 10.5, 'Постачальник1');", connection);
            ce.ExecuteNonQueryAsync();
            SqliteCommand ce1 = new SqliteCommand("INSERT INTO Products(ProductId, Name, Type, Cost, Supplier) VALUES(NULL, 'Груша', 'Фрукт', 12.2, 'Постачальник1');", connection);
            ce1.ExecuteNonQueryAsync();
            SqliteCommand ce2 = new SqliteCommand("INSERT INTO Products(ProductId, Name, Type, Cost, Supplier) VALUES(NULL, 'Огірок', 'Овоч', 16.2, 'Постачальник2');", connection);
            ce2.ExecuteNonQueryAsync();
            SqliteCommand ce3 = new SqliteCommand("INSERT INTO Products(ProductId, Name, Type, Cost, Supplier) VALUES(NULL, 'Помідор', 'Овоч', 15.2, 'Постачальник2');", connection);
            ce3.ExecuteNonQueryAsync();
            SqliteCommand ce4 = new SqliteCommand("INSERT INTO Products(ProductId, Name, Type, Cost, Supplier) VALUES(NULL, 'Корега', 'Інше', 20.5, 'Постачальник3');", connection);
            ce4.ExecuteNonQueryAsync();
            SqliteCommand ce5 = new SqliteCommand("INSERT INTO Products(ProductId, Name, Type, Cost, Supplier) VALUES(NULL, 'Кросівки', 'Інше', 12.6, 'Постачальник3');", connection);
            ce5.ExecuteNonQueryAsync();
            SqliteCommand ce6 = new SqliteCommand("INSERT INTO Products(ProductId, Name, Type, Cost, Supplier) VALUES(NULL, 'Зубна щітка', 'Інше', 11.1, 'Постачальник3');", connection);
            ce6.ExecuteNonQueryAsync();

            SqliteCommand c1e = new SqliteCommand("INSERT INTO Storage(StorageId, ProductId, Quantity, CostPrice, SupplyDate) VALUES(NULL, 1, 100, 10.0, '2023-01-01');", connection);
            c1e.ExecuteNonQueryAsync();
            SqliteCommand c1e2 = new SqliteCommand("INSERT INTO Storage(StorageId, ProductId, Quantity, CostPrice, SupplyDate) VALUES(NULL, 2, 50, 12.5, '2023-02-01');", connection);
            c1e2.ExecuteNonQueryAsync();
            SqliteCommand c1e3 = new SqliteCommand("INSERT INTO Storage(StorageId, ProductId, Quantity, CostPrice, SupplyDate) VALUES(NULL, 3, 75, 9.75, '2022-11-20');", connection);
            c1e3.ExecuteNonQueryAsync();
            SqliteCommand c1e4 = new SqliteCommand("INSERT INTO Storage(StorageId, ProductId, Quantity, CostPrice, SupplyDate) VALUES(NULL, 4, 80, 15.5, '2023-03-10');", connection);
            c1e4.ExecuteNonQueryAsync();
            SqliteCommand c1e5 = new SqliteCommand("INSERT INTO Storage(StorageId, ProductId, Quantity, CostPrice, SupplyDate) VALUES(NULL, 5, 40, 20.9, '2020-02-01');", connection);
            c1e5.ExecuteNonQueryAsync();
            SqliteCommand c1e6 = new SqliteCommand("INSERT INTO Storage(StorageId, ProductId, Quantity, CostPrice, SupplyDate) VALUES(NULL, 6, 150, 30.1, '2022-10-12');", connection);
            c1e6.ExecuteNonQueryAsync();
            SqliteCommand c1e7 = new SqliteCommand("INSERT INTO Storage(StorageId, ProductId, Quantity, CostPrice, SupplyDate) VALUES(NULL, 7, 90, 20.4, '2023-04-21');", connection);
            c1e7.ExecuteNonQueryAsync();
            SqliteCommand comm = new SqliteCommand("SELECT * FROM Products", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Add("1", "Id");
                dataGridView1.Columns.Add("2", "Name");
                dataGridView1.Columns.Add("3", "Type");
                dataGridView1.Columns.Add("4", "Cost");
                dataGridView1.Columns.Add("5", "Supplier");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Type")),
                            read.GetValue(read.GetOrdinal("Cost")),
                            read.GetValue(read.GetOrdinal("Supplier"))
                            });
                }
            }

        }
        public void DisplayAllStorage(SqliteConnection connection)
        {
            SqliteCommand comm = new SqliteCommand("SELECT * FROM Storage;", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "StorageId");
                dataGridView1.Columns.Add("2", "ProductId");
                dataGridView1.Columns.Add("3", "Quantity");
                dataGridView1.Columns.Add("4", "CostPrice");
                dataGridView1.Columns.Add("5", "SupplyDate");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("StorageId")),
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Quantity")),
                            read.GetValue(read.GetOrdinal("CostPrice")),
                            read.GetValue(read.GetOrdinal("SupplyDate"))
                            });
                }
            }
        }
        public void DisplayAllProducts(SqliteConnection connection)
        {

            SqliteCommand comm = new SqliteCommand("SELECT * FROM Products", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Id");
                dataGridView1.Columns.Add("2", "Name");
                dataGridView1.Columns.Add("3", "Type");
                dataGridView1.Columns.Add("4", "Cost");
                dataGridView1.Columns.Add("5", "Supplier");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Type")),
                            read.GetValue(read.GetOrdinal("Cost")),
                            read.GetValue(read.GetOrdinal("Supplier"))
                            });
                }
            }
        }

        public void DisplayAllTypes(SqliteConnection connection)
        {
            SqliteCommand comm = new SqliteCommand("SELECT DISTINCT Type FROM Products", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Type");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("Type"))
                            });
                }
            }
        }

        public void DisplayAllSuppliers(SqliteConnection connection)
        {
            SqliteCommand comm = new SqliteCommand("SELECT DISTINCT Supplier FROM Products", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Supplier");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("Supplier"))
                            });
                }
            }
        }

        public void DisplayMaxQuantity(SqliteConnection connection)
        {
            //Показати товар з максимальною кількістю.
            SqliteCommand command1 = new SqliteCommand("SELECT MAX(Quantity) FROM Storage", connection);
            SqliteDataReader reader1 = command1.ExecuteReader();
            string temp = "";
            while (reader1.Read())
            {
                temp += reader1["MAX(Quantity)"];
            }

            reader1.Close();
            temp = temp.Replace(',', '.');
            SqliteCommand comm = new SqliteCommand($"SELECT * FROM Products WHERE ProductId IN ( SELECT ProductId FROM Storage WHERE Quantity = '{temp}');", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Id");
                dataGridView1.Columns.Add("2", "Name");
                dataGridView1.Columns.Add("3", "Type");
                dataGridView1.Columns.Add("4", "Cost");
                dataGridView1.Columns.Add("5", "Supplier");
                dataGridView1.Columns.Add("6", "Quantity");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Type")),
                            read.GetValue(read.GetOrdinal("Cost")),
                            read.GetValue(read.GetOrdinal("Supplier")),
                            temp
                            });
                }
            }
        }
        public void DisplayMinQuantity(SqliteConnection connection)
        {
            //Показати товар з мінімальною кількістю.
            SqliteCommand command1 = new SqliteCommand("SELECT MIN(Quantity) FROM Storage", connection);
            SqliteDataReader reader1 = command1.ExecuteReader();
            string temp = "";
            while (reader1.Read())
            {
                temp += reader1["MIN(Quantity)"];
            }

            reader1.Close();
            temp = temp.Replace(',', '.');
            SqliteCommand comm = new SqliteCommand($"SELECT * FROM Products WHERE ProductId IN ( SELECT ProductId FROM Storage WHERE Quantity = '{temp}');", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Id");
                dataGridView1.Columns.Add("2", "Name");
                dataGridView1.Columns.Add("3", "Type");
                dataGridView1.Columns.Add("4", "Cost");
                dataGridView1.Columns.Add("5", "Supplier");
                dataGridView1.Columns.Add("6", "Quantity");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Type")),
                            read.GetValue(read.GetOrdinal("Cost")),
                            read.GetValue(read.GetOrdinal("Supplier")),
                            temp
                            });
                }
            }
        }
        public void DisplayMaxCostPrice(SqliteConnection connection)
        {
            //Показати товар з максимальною собівартістю.
            SqliteCommand command1 = new SqliteCommand("SELECT MAX(CostPrice) FROM Storage", connection);
            SqliteDataReader reader1 = command1.ExecuteReader();
            string temp = "";
            while (reader1.Read())
            {
                temp += reader1["MAX(CostPrice)"];
            }

            reader1.Close();
            temp = temp.Replace(',', '.');
            SqliteCommand comm = new SqliteCommand($"SELECT * FROM Products WHERE ProductId IN ( SELECT ProductId FROM Storage WHERE CostPrice = '{temp}');", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Id");
                dataGridView1.Columns.Add("2", "Name");
                dataGridView1.Columns.Add("3", "Type");
                dataGridView1.Columns.Add("4", "Cost");
                dataGridView1.Columns.Add("5", "Supplier");
                dataGridView1.Columns.Add("6", "CostPrice");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Type")),
                            read.GetValue(read.GetOrdinal("Cost")),
                            read.GetValue(read.GetOrdinal("Supplier")),
                            temp
                            });
                }
            }
        }
        public void DisplayMinCostPrice(SqliteConnection connection)
        {
            //Показати товар з мінімальною собівартістю.
            SqliteCommand command1 = new SqliteCommand("SELECT MIN(CostPrice) FROM Storage;", connection);
            SqliteDataReader reader1 = command1.ExecuteReader();
            string temp = "";
            while (reader1.Read())
            {
                temp += reader1["MIN(CostPrice)"];
            }

            reader1.Close();
            temp = temp.Replace(',', '.');
            SqliteCommand comm = new SqliteCommand($"SELECT * FROM Products WHERE ProductId IN ( SELECT ProductId FROM Storage WHERE CostPrice = '{temp}');", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Id");
                dataGridView1.Columns.Add("2", "Name");
                dataGridView1.Columns.Add("3", "Type");
                dataGridView1.Columns.Add("4", "Cost");
                dataGridView1.Columns.Add("5", "Supplier");
                dataGridView1.Columns.Add("6", "CostPrice");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Type")),
                            read.GetValue(read.GetOrdinal("Cost")),
                            read.GetValue(read.GetOrdinal("Supplier")),
                            temp
                            });
                }
            }
        }
        public void DisplayAvgQuantityByType(SqliteConnection connection)
        {
            //Показати середню кількість товарів за кожним типом товару.
            SqliteCommand avgQuantityCommand = new SqliteCommand("SELECT AVG(Quantity) FROM Storage WHERE ProductId IN ( SELECT ProductId FROM Products WHERE Type='Фрукт');", connection);
            SqliteCommand avgQuantityCommand1 = new SqliteCommand("SELECT AVG(Quantity) FROM Storage WHERE ProductId IN ( SELECT ProductId FROM Products WHERE Type='Овоч');", connection);
            SqliteCommand avgQuantityCommand2 = new SqliteCommand("SELECT AVG(Quantity) FROM Storage WHERE ProductId IN ( SELECT ProductId FROM Products WHERE Type='Інше');", connection);
            using (SqliteDataReader read = avgQuantityCommand.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Type");
                dataGridView1.Columns.Add("2", "Quantity");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            "Фрукт",
                            read.GetValue(read.GetOrdinal("AVG(Quantity)"))
                            });
                }
            }
            using (SqliteDataReader read1 = avgQuantityCommand1.ExecuteReader())
            {

                while (read1.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                        "Овоч",
                            read1.GetValue(read1.GetOrdinal("AVG(Quantity)"))
                            });
                }
            }
            using (SqliteDataReader read2 = avgQuantityCommand2.ExecuteReader())
            {

                while (read2.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                        "Інше",
                            read2.GetValue(read2.GetOrdinal("AVG(Quantity)"))
                            });
                }
            }
        }
        public void DisplayAllInfoOfAProduct(SqliteConnection connection)
        {
            //Відображення всієї інформації про товар.
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть ід товару", "Ввід даних", "1", -1, -1);
            int productid;
            bool success = int.TryParse(input, out productid);
            SqliteCommand comm = new SqliteCommand($"SELECT * FROM Products WHERE ProductId = {productid};", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Id");
                dataGridView1.Columns.Add("2", "Name");
                dataGridView1.Columns.Add("3", "Type");
                dataGridView1.Columns.Add("4", "Cost");
                dataGridView1.Columns.Add("5", "Supplier");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Type")),
                            read.GetValue(read.GetOrdinal("Cost")),
                            read.GetValue(read.GetOrdinal("Supplier"))
                            });
                }
            }
        }

        public void DisplayItemsByType(SqliteConnection connection)
        {
            //Показати товари заданої категорії.
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть тип товару", "Ввід даних", "Фрукт", -1, -1);
            SqliteCommand comm = new SqliteCommand($"SELECT * FROM Products WHERE Type = '{input}';", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Id");
                dataGridView1.Columns.Add("2", "Name");
                dataGridView1.Columns.Add("3", "Type");
                dataGridView1.Columns.Add("4", "Cost");
                dataGridView1.Columns.Add("5", "Supplier");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Type")),
                            read.GetValue(read.GetOrdinal("Cost")),
                            read.GetValue(read.GetOrdinal("Supplier"))
                            });
                }
            }
        }
        public void DisplayItemsBySupplier(SqliteConnection connection)
        {
            //Показати товари заданого постачальника.
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть постачальника товару", "Ввід даних", "Постачальник1", -1, -1);
            SqliteCommand comm = new SqliteCommand($"SELECT * FROM Products WHERE Supplier = '{input}';", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Id");
                dataGridView1.Columns.Add("2", "Name");
                dataGridView1.Columns.Add("3", "Type");
                dataGridView1.Columns.Add("4", "Cost");
                dataGridView1.Columns.Add("5", "Supplier");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Type")),
                            read.GetValue(read.GetOrdinal("Cost")),
                            read.GetValue(read.GetOrdinal("Supplier"))
                            });
                }
            }
        }
        public void DisplayOldestItemInStorage(SqliteConnection connection)
        {
            //Показати товар, який знаходиться на складі найдовше з усіх.
            string query1 = "SELECT MIN(SupplyDate) FROM Storage;";
            SqliteCommand command1 = new SqliteCommand(query1, connection);
            SqliteDataReader reader1 = command1.ExecuteReader();
            string temp = "";
            while (reader1.Read())
            {
                temp += reader1["min(SupplyDate)"];
            }

            reader1.Close();
            SqliteCommand comm = new SqliteCommand($"SELECT * FROM Products WHERE ProductId IN ( SELECT ProductId FROM Storage WHERE SupplyDate = '{temp}');", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Id");
                dataGridView1.Columns.Add("2", "Name");
                dataGridView1.Columns.Add("3", "Type");
                dataGridView1.Columns.Add("4", "Cost");
                dataGridView1.Columns.Add("5", "Supplier");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Type")),
                            read.GetValue(read.GetOrdinal("Cost")),
                            read.GetValue(read.GetOrdinal("Supplier"))
                            });
                }
            }
        }

        private void DisplayAllSt_Click(object sender, EventArgs e)
        {
            DisplayAllStorage(connection);
        }

        private void DisplayAllPr_Click(object sender, EventArgs e)
        {
            DisplayAllProducts(connection);
        }

        private void DisplayAllTy_Click(object sender, EventArgs e)
        {
            DisplayAllTypes(connection);
        }

        private void DisplayAllSup_Click(object sender, EventArgs e)
        {
            DisplayAllSuppliers(connection);
        }

        private void DisplayMaxQu_Click(object sender, EventArgs e)
        {
            DisplayMaxQuantity(connection);
        }

        private void DisplayMinQu_Click(object sender, EventArgs e)
        {
            DisplayMinQuantity(connection);
        }

        private void DisplayMaxCostPr_Click(object sender, EventArgs e)
        {
            DisplayMaxCostPrice(connection);
        }

        private void DisplayMinCostPr_Click(object sender, EventArgs e)
        {
            DisplayMinCostPrice(connection);
        }

        private void DisplayAvgQuanByType_Click(object sender, EventArgs e)
        {
            DisplayAvgQuantityByType(connection);
        }

        private void DisplayAllInfoOfAPr_Click(object sender, EventArgs e)
        {
            DisplayAllInfoOfAProduct(connection);
        }

        private void DisplayItemsByTy_Click(object sender, EventArgs e)
        {
            DisplayItemsByType(connection);
        }

        private void DisplayItemBySup_Click(object sender, EventArgs e)
        {
            DisplayItemsBySupplier(connection);
        }

        private void DisplayOldestItem_Click(object sender, EventArgs e)
        {
            DisplayOldestItemInStorage(connection);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть назву, тип, ціну, постачальника, кількість, собівартість, дату постачання товару через кому. Наприклад: Назва1,Тип2,123,Постачальник4...", "Ввід даних", "", -1, -1);
            List<string> newobject = input.Split(",").ToList<string>();
            SqliteCommand comm = new SqliteCommand($"INSERT INTO Products(ProductId, Name, Type, Cost, Supplier) VALUES(NULL, '{newobject[0]}', '{newobject[1]}', {newobject[2]}, '{newobject[3]}');", connection);
            comm.ExecuteNonQueryAsync();
            int tempid = 0;
            SqliteCommand comm3 = new SqliteCommand("SELECT * FROM Products", connection);
            using (SqliteDataReader read = comm3.ExecuteReader())
            {
                while (read.Read())
                {
                    tempid = read.GetInt32(read.GetOrdinal("ProductId"));
                }
            }
            SqliteCommand comm1 = new SqliteCommand($"INSERT INTO Storage(StorageId, ProductId, Quantity, CostPrice, SupplyDate) VALUES(NULL, {tempid}, {newobject[4]}, {newobject[5]}, '{newobject[6]}');", connection);
            comm1.ExecuteNonQueryAsync();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть ід товару", "Ввід даних", "1", -1, -1);
            int productid;
            bool success = int.TryParse(input, out productid);

            string input1 = Microsoft.VisualBasic.Interaction.InputBox("Введіть назву, тип, ціну, постачальника, кількість, собівартість, дату постачання товару через кому. Наприклад: Назва1,Тип2,123,Постачальник4...", "Оновлення даних", "", -1, -1);
            List<string> newobject = input1.Split(",").ToList<string>();
            SqliteCommand comm = new SqliteCommand($"UPDATE Products SET Name = '{newobject[0]}', Type = '{newobject[1]}', Cost = {newobject[2]}, Supplier = '{newobject[3]}' WHERE ProductId = {productid};", connection);
            comm.ExecuteNonQueryAsync();
            SqliteCommand comm1 = new SqliteCommand($"UPDATE Storage SET Quantity = {newobject[4]}, CostPrice = {newobject[5]}, SupplyDate = '{newobject[6]}' WHERE ProductId = {productid};", connection);
            comm1.ExecuteNonQueryAsync();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть тип товару для зміни", "Оновлення даних", "Фрукт", -1, -1);
            string input1 = Microsoft.VisualBasic.Interaction.InputBox("Введіть новий тип товару", "Оновлення даних", "", -1, -1);
            SqliteCommand comm = new SqliteCommand($"UPDATE Products SET Type = '{input1}' WHERE Type = '{input}';", connection);
            comm.ExecuteNonQueryAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть постачальника товару для зміни", "Оновлення даних", "Постачальник1", -1, -1);
            string input1 = Microsoft.VisualBasic.Interaction.InputBox("Введіть нового постачальника товару", "Оновлення даних", "", -1, -1);
            SqliteCommand comm = new SqliteCommand($"UPDATE Products SET Supplier = '{input1}' WHERE Supplier = '{input}';", connection);
            comm.ExecuteNonQueryAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть ід товару", "Видалення даних", "1", -1, -1);
            int productid;
            bool success = int.TryParse(input, out productid);
            SqliteCommand comm = new SqliteCommand($"DELETE FROM Storage WHERE ProductId = {productid};", connection);
            comm.ExecuteNonQueryAsync();
            SqliteCommand comm1 = new SqliteCommand($"DELETE FROM Products WHERE ProductId = {productid};", connection);
            comm1.ExecuteNonQueryAsync();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть тип товару", "Видалення даних", "", -1, -1);
            List<int> tempids = new List<int>();
            SqliteCommand comm3 = new SqliteCommand($"SELECT * FROM Products WHERE Type = '{input}'", connection);
            using (SqliteDataReader read = comm3.ExecuteReader())
            {
                while (read.Read())
                {
                    tempids.Add(read.GetInt32(read.GetOrdinal("ProductId")));
                }
            }
            foreach (int id in tempids)
            {
                SqliteCommand comm1 = new SqliteCommand($"DELETE FROM Storage WHERE ProductId = {id};", connection);
                comm1.ExecuteNonQueryAsync();
            }
            SqliteCommand comm = new SqliteCommand($"DELETE FROM Products WHERE Type = '{input}';", connection);
            comm.ExecuteNonQueryAsync();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть постачальника товару", "Видалення даних", "", -1, -1);
            List<int> tempids = new List<int>();
            SqliteCommand comm3 = new SqliteCommand($"SELECT * FROM Products WHERE Supplier = '{input}'", connection);
            using (SqliteDataReader read = comm3.ExecuteReader())
            {
                while (read.Read())
                {
                    tempids.Add(read.GetInt32(read.GetOrdinal("ProductId")));
                }
            }
            foreach (int id in tempids)
            {
                SqliteCommand comm1 = new SqliteCommand($"DELETE FROM Storage WHERE ProductId = {id};", connection);
                comm1.ExecuteNonQueryAsync();
            }
            SqliteCommand comm = new SqliteCommand($"DELETE FROM Products WHERE Supplier = '{input}';", connection);
            comm.ExecuteNonQueryAsync();
        }

        private void SupMaxQuan_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT MAX(Quantity) FROM Storage;";
            SqliteCommand command1 = new SqliteCommand(query1, connection);
            SqliteDataReader reader1 = command1.ExecuteReader();
            string temp = "";
            while (reader1.Read())
            {
                temp += reader1["MAX(Quantity)"];
            }

            reader1.Close();
            SqliteCommand comm = new SqliteCommand($"SELECT Supplier FROM Products WHERE ProductId IN ( SELECT ProductId FROM Storage WHERE Quantity = {temp});", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Supplier");
                dataGridView1.Columns.Add("2", "Quantity");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("Supplier")),
                            temp
                            });
                }
            }
        }

        private void SupMinQuan_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT MIN(Quantity) FROM Storage;";
            SqliteCommand command1 = new SqliteCommand(query1, connection);
            SqliteDataReader reader1 = command1.ExecuteReader();
            string temp = "";
            while (reader1.Read())
            {
                temp += reader1["MIN(Quantity)"];
            }

            reader1.Close();
            SqliteCommand comm = new SqliteCommand($"SELECT Supplier FROM Products WHERE ProductId IN ( SELECT ProductId FROM Storage WHERE Quantity = {temp});", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Supplier");
                dataGridView1.Columns.Add("2", "Quantity");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("Supplier")),
                            temp
                            });
                }
            }
        }

        private void TypeMaxQuan_Click(object sender, EventArgs e)
        {

            string query1 = "SELECT MAX(Quantity) FROM Storage;";
            SqliteCommand command1 = new SqliteCommand(query1, connection);
            SqliteDataReader reader1 = command1.ExecuteReader();
            string temp = "";
            while (reader1.Read())
            {
                temp += reader1["MAX(Quantity)"];
            }

            reader1.Close();
            SqliteCommand comm = new SqliteCommand($"SELECT Type FROM Products WHERE ProductId IN ( SELECT ProductId FROM Storage WHERE Quantity = {temp});", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Type");
                dataGridView1.Columns.Add("2", "Quantity");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("Type")),
                            temp
                            });
                }
            }
        }

        private void TypeMinQuan_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT MIN(Quantity) FROM Storage;";
            SqliteCommand command1 = new SqliteCommand(query1, connection);
            SqliteDataReader reader1 = command1.ExecuteReader();
            string temp = "";
            while (reader1.Read())
            {
                temp += reader1["MIN(Quantity)"];
            }

            reader1.Close();
            SqliteCommand comm = new SqliteCommand($"SELECT Type FROM Products WHERE ProductId IN ( SELECT ProductId FROM Storage WHERE Quantity = {temp});", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Type");
                dataGridView1.Columns.Add("2", "Quantity");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("Type")),
                            temp
                            });
                }
            }
        }

        private void NumOfDays_Click(object sender, EventArgs e)
        {

            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть кількість днів", "Ввід даних", "1", -1, -1);
            int days;
            bool success = int.TryParse(input, out days);
            SqliteCommand comm = new SqliteCommand($"SELECT * FROM Products WHERE ProductId IN ( SELECT ProductId FROM Storage WHERE (strftime('%s', 'now') - strftime('%s', SupplyDate)) / 86400.0 BETWEEN {days - 1} AND {days + 1});", connection);
            using (SqliteDataReader read = comm.ExecuteReader())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("1", "Id");
                dataGridView1.Columns.Add("2", "Name");
                dataGridView1.Columns.Add("3", "Type");
                dataGridView1.Columns.Add("4", "Cost");
                dataGridView1.Columns.Add("5", "Supplier");
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Type")),
                            read.GetValue(read.GetOrdinal("Cost")),
                            read.GetValue(read.GetOrdinal("Supplier"))
                            });
                }
            }
        }
    }
}