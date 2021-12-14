using System;
using System.Collections.Generic;
using System.Text;

namespace Commodities_Manager___Console
{
    public struct category
    {
        public string categoryID;
        public string categoryName;
        public int amount;
    }
    public class Categories
    {
        public static category[] dataTableCategory()
        {
            category[] newDataTableCategory = new category[1];

            newDataTableCategory[0].categoryID = "C001";
            newDataTableCategory[0].categoryName = "Supplement";
            for (int i = 0; i < Product.dataTableProduct().Length; i++)
            {
                if (Product.dataTableProduct()[i].category == newDataTableCategory[0].categoryName)
                { 
                    newDataTableCategory[0].amount = newDataTableCategory[0].amount + Product.dataTableProduct()[i].amount;
                }
            }

            return newDataTableCategory;
        }

        public static void exportCategoriesData(category[] dataCategories)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("| Categories ID | Category   | Amount |");
            Console.WriteLine("---------------------------------------");
            for (int i = 0; i < dataCategories.Length; i++)
            {
                Console.WriteLine($"| {dataCategories[i].categoryID}          | {dataCategories[i].categoryName} | {dataCategories[i].amount}    |");
            }
            Console.WriteLine("---------------------------------------");
        }
        public static void drawTableHeader()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("| Categories ID | Category   | Amount |");
            Console.WriteLine("---------------------------------------");
        }
        public static void drawTableFooter()
        {
            Console.WriteLine("---------------------------------------");
        }
        public static void exportSearchResult(category searchResult)
        {
            Console.WriteLine($"| {searchResult.categoryID}          | {searchResult.categoryName} | {searchResult.amount}    |");
        }
        public static category[] updateDataTableCategory(category[] data, category newCategory)
        {
            category[] newData = new category[data.Length + 1];
            for (int i = 0; i < newData.Length - 1; i++)
            {
                newData[i] = dataTableCategory()[i];

            }
            newData[newData.Length - 1] = newCategory;
            return newData;
        }

        public static category addCategory(string note)
        {
            //Create a new category
            Console.WriteLine(note);
            category B = new category();

              
            while (true) //add product ID
            {
                Console.WriteLine("Category ID:");
                B.categoryID = Console.ReadLine();

                if (B.categoryID.Length > 4)
                {
                    Console.WriteLine("Category ID must be less than or equal to 4 digits!");
                    continue;
                }
                else if (B.categoryID.Length < 4)
                {
                    for (int i = B.categoryID.Length; i < 4; i++)
                    {
                        B.categoryID = B.categoryID + " ";
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
                Console.WriteLine("Category Name:");
                B.categoryName = Console.ReadLine();
                if (B.categoryName.Length > 10)
                {
                    Console.WriteLine("Category Name must be less than or equal to 10 digits!");
                    continue;
                }
                else if (B.categoryName.Length < 10)
                {
                    for (int i = B.categoryName.Length; i < 10; i++)
                    {
                        B.categoryName = B.categoryName + " ";
                    }
                    break;
                }
                else
                    break;
            }

            B.amount = 0; // add product's amount
            foreach (product goods in Product.dataTableProduct())
            {
                if (B.categoryName == goods.category)
                {
                    B.amount = B.amount + goods.amount;
                }
            }            

            return B;
        }
        public static category[] deleteCategory(category[] dataCategory, string deletedCategoryID)
        {
            


            //Get the index of item to be deleted
            int index = new int();
            for (int i = 0; i < dataCategory.Length; i++)
            {
                if (dataCategory[i].categoryID == deletedCategoryID)
                {
                    index = i;
                }
            }
            category[] newDataCategory = new category[dataCategory.Length - 1]; //Create a new array

            //Copy the item before and after the deleted item in product data to the new array
            for (int i = 0; i < index; i++)
            {
                newDataCategory[i] = dataCategory[i];
            }
            for (int j = index + 1; j < dataCategory.Length; j++)
            {
                newDataCategory[j - 1] = dataCategory[j];
            }
            return newDataCategory;
        }
        public static void editCategory(category[] dataCategory)
        {
            Console.WriteLine("Input Category ID you would like to edit here:");
            string keyword = Console.ReadLine();

            while (true)
            {
                for (int i = 0; i < dataCategory.Length; i++)
                {
                    if (dataCategory[i].categoryID == keyword)
                    {
                        dataCategory[i] = addCategory("Edit the product:");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No Search Found!");
                        continue;
                    }
                }
            }
        }
        public static void searchCategory (category[] dataCategory)
        {
            Console.WriteLine("Which one in category would you like to search by? (Press number)");
            Console.WriteLine("1. By Category ID");
            Console.WriteLine("2. By Category Name");
            Console.WriteLine("3. Back to previous menu");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1: //Search by Category ID
                    {
                        Console.WriteLine("Type a keyword to search:");
                        string keyword = Console.ReadLine();

                        drawTableHeader();
                        foreach(category search in dataCategory)
                        {
                            if(search.categoryID.Contains(keyword))
                            {
                                exportSearchResult(search);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("| No Search Found                     |");
                                break;
                            }
                        }
                        drawTableFooter();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Type a keyword to search:");
                        string keyword = Console.ReadLine();

                        drawTableHeader();
                        foreach (category search in dataCategory)
                        {
                            if (search.categoryID.Contains(keyword))
                            {
                                exportSearchResult(search);                                
                            }
                            else
                            {
                                Console.WriteLine("| No Search Found                     |");
                                break;
                            }
                        }
                        drawTableFooter();
                        break;
                    }
                case 3:
                    {
                        Program.categoriesPage();
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
