using System;
using System.Collections.Generic;
using System.Text;

namespace Commodities_Manager___Console
{
    public struct product
    {
        public string productID;
        public string productName;
        public int mfgYear;
        public string manufacturer;
        public int expDate;
        public string category;
        public int amount;
        public int price;
    }

    public class Product
    {
        public static product addProduct(string note)
        {
            Console.WriteLine(note);
            product A = new product();

            while (true) // add product ID
            {
                Console.WriteLine("Product ID:");
                A.productID = Console.ReadLine();
                
                if (A.productID.Length > 4)
                {
                    Console.WriteLine("Product ID must be less than or equal to 4 digits!");
                    continue;
                }
                else if (A.productID.Length < 4)
                {
                    for (int i = A.productID.Length; i < 4; i++)
                    {
                        A.productID = A.productID + " ";
                    }
                    break;
                }
                else
                { 
                    break; 
                }             
            }

            while (true) // add product name
            {
                Console.WriteLine("Product Name:");
                A.productName = Console.ReadLine();
                if (A.productName.Length > 34)
                {
                    Console.WriteLine("Product Name must be less than or equal to 34 digits!");
                    continue;
                }
                else if (A.productName.Length < 34)
                {
                    for (int i = A.productName.Length; i < 34; i++)
                    {
                        A.productName = A.productName + " ";
                    }
                    break;
                }
                else
                    break;
            }

            while (true) // add product's manufacturing date
            {
                Console.WriteLine("Manufacturing Date:");
                A.mfgYear = int.Parse(Console.ReadLine());
                if (A.mfgYear < 1900 || A.mfgYear > 2021)
                {
                    Console.WriteLine("Please input an invalid year!");
                    continue;
                }
                else
                    break;
            }

            while (true) // add product's expiry date
            {
                Console.WriteLine("Expiry Date:");
                A.expDate = int.Parse(Console.ReadLine());
                if (A.expDate < A.mfgYear || A.expDate > 2100)
                {
                    Console.WriteLine("Please input an invalid year!");
                    continue;
                }
                else
                    break;
            }
            

            while (true) // add product's manufacturer
            {
                Console.WriteLine("Manufacturer Name:");
                A.manufacturer = Console.ReadLine();
                if (A.manufacturer.Length > 8)
                {
                    Console.WriteLine("Manufacturer Name must be less than or equal to 8 digits!");
                    continue;
                }
                else if (A.manufacturer.Length < 8)
                {
                    for (int i = A.manufacturer.Length; i < 8; i++)
                    {
                        A.manufacturer = A.manufacturer + " ";
                    }
                    break;
                }
                else
                    break;
            }

            while (true) // add product's category
            {
                Console.WriteLine("Category:");
                A.category = Console.ReadLine();
                if (A.category.Length > 10)
                {
                    Console.WriteLine("Category must be less than or equal to 8 digits!");
                    continue;
                }
                else if (A.category.Length < 10)
                {
                    for (int i = A.category.Length; i < 10; i++)
                    {
                        A.category = A.category + " ";
                    }
                    break;
                }
                else
                    break;
            }

            while (true) // add product's amount
            {
                Console.WriteLine("Amount:");
                A.amount = int.Parse(Console.ReadLine());
                if (A.amount < 0 || A.amount > 999)
                {
                    Console.WriteLine("Please input an invalid amount between 0 and 999!");
                    continue;
                }
                else
                    break;
            }

            while (true) // add product's price
            {
                Console.WriteLine("Price:");
                A.price = int.Parse(Console.ReadLine());
                if (A.price < 0 || A.price > 999999)
                {
                    Console.WriteLine("Please input an invalid price between 0 and 999999!");
                    continue;
                }
                else
                    break;
            }            

            return A;
        }

        
        public static product[] dataTableProduct()
        {
            product[] dataTableProduct = new product[3];

            dataTableProduct[0].productID = "P001";
            dataTableProduct[0].productName = "Kirkland Signature Vitamin E 180mg";
            dataTableProduct[0].mfgYear = 2020;
            dataTableProduct[0].expDate = 2025;
            dataTableProduct[0].manufacturer = "Kirkland";
            dataTableProduct[0].category = "Supplement";
            dataTableProduct[0].amount = 100;
            dataTableProduct[0].price = 400000;

            dataTableProduct[1].productID = "P002";
            dataTableProduct[1].productName = "Kirkland Signature Fish Oil 1000mg";
            dataTableProduct[1].mfgYear = 2020;
            dataTableProduct[1].expDate = 2025;
            dataTableProduct[1].manufacturer = "Kirkland";
            dataTableProduct[1].category = "Supplement";
            dataTableProduct[1].amount = 240;
            dataTableProduct[1].price = 550000;

            dataTableProduct[2].productID = "P003";
            dataTableProduct[2].productName = "Kirkland Signature Vitamin C 180mg";
            dataTableProduct[2].mfgYear = 2020;
            dataTableProduct[2].expDate = 2025;
            dataTableProduct[2].manufacturer = "Kirkland";
            dataTableProduct[2].category = "Supplement";
            dataTableProduct[2].amount = 440;
            dataTableProduct[2].price = 350000;

            return dataTableProduct;
        }

        public static product[] updateDataTableProduct(product[] currentData,product newProduct)
        {
            product[] newData = new product[currentData.Length + 1];
            for (int i = 0; i < newData.Length - 1; i++)
            {
                newData[i] = currentData[i];
                
            }
            newData[newData.Length - 1] = newProduct;
            return newData;
        }

        public static void exportProductData (product[] dataProduct)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Product ID | Product Name                       | MFG Date | EXP Date | Manufacturer | Category   | Amount | Price      |");
            Console.WriteLine("|-------------------------------------------------------------------------------------------------------------------------|");
            for (int i = 0; i < dataProduct.Length; i++)
            {
                Console.WriteLine($"| {dataProduct[i].productID}       | {dataProduct[i].productName} | {dataProduct[i].mfgYear}     | {dataProduct[i].expDate}     | {dataProduct[i].manufacturer}     | {dataProduct[i].category} | {dataProduct[i].amount}    | {dataProduct[i].price}     |");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
        }
        
        public static void editProduct(product[] dataProduct)
        {            

            while (true)
            {
                Console.WriteLine("Input Product ID you would like to edit here:");
                string keyword = Console.ReadLine();

                int index = 0;
                int found = 0;

                for (int i = 0; i < dataProduct.Length; i++)
                {
                    if (dataProduct[i].productID == keyword)
                    {
                        index = i;
                        found = 1;
                        break;
                    }
                    else
                        continue;
                }

                if (found == 1)
                {
                    dataProduct[index] = addProduct("Edit product:");
                    break;
                }
                else                   
                {
                    Console.WriteLine("No search found!");
                    continue;
                }

            }
        }
        public static product[] deleteProduct(product[] dataProduct, string productID)
        {         
            //Get the index of item to be deleted
            int index = new int();
            for (int i = 0; i < dataProduct.Length; i++)
            {
                if (dataProduct[i].productID == productID)
                {
                    index = i;
                }    
            }
            product[] newDataProduct = new product[dataProduct.Length - 1]; //Create a new array

            //Copy the item before and after the deleted item in product data to the new array
            for (int i = 0; i < index; i++)
            {
                newDataProduct[i] = dataProduct[i];
            }
            for (int j = index + 1; j < dataProduct.Length; j++)
            { 
                newDataProduct[j - 1] = dataProduct[j];
            }            
            return newDataProduct;
        }
        
        public static void exportSearchResult(product searchResult)
        {
            Console.WriteLine($"| {searchResult.productID}       | {searchResult.productName} | {searchResult.mfgYear}     | {searchResult.expDate}     | {searchResult.manufacturer}     | {searchResult.category} | {searchResult.amount}    | {searchResult.price}     |");
        }
        public static void drawTableHeader()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Product ID | Product Name                       | MFG Date | EXP Date | Manufacturer | Category   | Amount | Price      |");
            Console.WriteLine("|-------------------------------------------------------------------------------------------------------------------------|");
        }
        public static void drawTableFooter()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
        }
        public static void searchProduct (product[] dataProduct)
        {
            
                Console.WriteLine("Which one would you like to search by? (Press number)");
                Console.WriteLine("1. By Product ID");
                Console.WriteLine("2. By Product Name");
                Console.WriteLine("3. By MFG Year");
                Console.WriteLine("4. By EXP Year");
                Console.WriteLine("5. By Manufacturer");
                Console.WriteLine("6. By Category");
                Console.WriteLine("7. Back to previous menu");
                int selection = int.Parse(Console.ReadLine());
                

            switch (selection)
            {
                case 1: // search by Product ID
                    {
                        Console.WriteLine("Type a keyword to search:");
                        string keyword = Console.ReadLine();
                        

                        drawTableHeader();
                        foreach (product search in dataProduct)
                        {
                            if (search.productID.Contains(keyword))
                            {
                                exportSearchResult(search);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("| No Search Found                                                                                                         |");
                                break;
                            }
                        }
                        drawTableFooter();
                        break;
                    }
                case 2: // search by Product name
                    {
                        Console.WriteLine("Type a keyword to search:");
                        string keyword = Console.ReadLine();
                        bool found = false;

                        drawTableHeader();
                        foreach (product search in dataProduct)
                        {
                            if (search.productName.Contains(keyword))
                            {
                                exportSearchResult(search);
                                found = true;
                            }                            
                        }
                        if (found == false)
                        {
                            Console.WriteLine("| No Search Found                                                                                                         |");
                        }
                        drawTableFooter();
                        break;
                    }
                case 3: // search by MFG Date
                    {
                        Console.WriteLine("Type a keyword to search:");
                        int keyword = int.Parse(Console.ReadLine());

                        bool found = false;
                        drawTableHeader();
                        foreach(product search in dataProduct)
                        {
                            if (search.mfgYear == keyword)
                            {
                                exportSearchResult(search);
                                found = true;
                            }
                            
                        }
                        if (found == false)
                        {
                            Console.WriteLine("| No Search Found                                                                                                         |");
                        }
                        drawTableFooter();
                        break;
                    }
                case 4: //search by exp Date
                    {
                        Console.WriteLine("Type a keyword to search:");
                        int keyword = int.Parse(Console.ReadLine());
                        bool found = false;

                        drawTableHeader();
                        foreach (product search in dataProduct)
                        {
                            if (search.expDate == keyword)
                            {
                                exportSearchResult(search);
                                found = true;
                            }
                            
                        }
                        if(found == false)
                        {
                            Console.WriteLine("| No Search Found                                                                                                         |");                            
                        }
                        drawTableFooter();
                        break;
                    }
                case 5: // search by manufacturer
                    {
                        Console.WriteLine("Type a keyword to search:");
                        string keyword = Console.ReadLine();
                        bool found = false;

                        drawTableHeader();
                        foreach (product search in dataProduct)
                        {
                            if (search.manufacturer.Contains(keyword))
                            {
                                exportSearchResult(search);
                                found = true;
                            }                           
                        }
                        if (found == false)
                        {
                            Console.WriteLine("| No Search Found                                                                                                         |");
                        }
                        drawTableFooter();
                        break;
                    }
                case 6: // search by category
                    {
                        Console.WriteLine("Type a keyword to search:");
                        string keyword = Console.ReadLine();
                        bool found = false;

                        drawTableHeader();
                        foreach (product search in dataProduct)
                        {
                            if (search.category.Contains(keyword))
                            {
                                exportSearchResult(search);
                                found = true;
                            }
                            
                        }
                        if (found == false)
                        {
                            Console.WriteLine("| No Search Found                                                                                                         |");                            
                        }
                        drawTableFooter();
                        break;
                    }
                case 7: // back to previous menu
                    {
                        Program.productPage();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Please input a valid number!");
                        break;
                    }
                              
            }
        }
    }
}
