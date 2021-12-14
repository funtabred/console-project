using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commodities_Manager___Console
{
    class Program
    {
        static void Main(string[] args)
        {
            mainMenu();
        }
        public static void mainMenu()
        {
            Console.WriteLine("Hi User! Welcome to inventory management! What would you like to do?");
            Console.WriteLine("1. Product");
            Console.WriteLine("2. Categories");
            Console.WriteLine("3. About");
            Console.WriteLine("4. Quit");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    {
                        productPage();
                        break;
                    }
                case 2:
                    {
                        categoriesPage();
                        break;
                    }
                case 3:
                    {
                        aboutPage();
                        break;
                    }
                case 4:
                    {
                        System.Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please press a valid number!");
                        break;
                    }
            }
        }
        public static void productPage()
        {
            product[] dataTable = Product.dataTableProduct();
            Product.exportProductData(dataTable);

            Console.WriteLine("What would you like to do? (Press number)");
            Console.WriteLine("1. Add a Product");
            Console.WriteLine("2. Edit a Product");
            Console.WriteLine("3. Delete a Product");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Back to main menu");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    {
                        product newProduct = Product.addProduct("New Product:");
                        dataTable = Product.updateDataTableProduct(dataTable, newProduct);
                        Console.WriteLine("Product added successfully!");
                        Product.exportProductData(dataTable);
                        break;
                    }
                case 2:
                    {
                        Product.editProduct(dataTable);
                        Console.WriteLine("Product updated successfully!");
                        Product.exportProductData(dataTable);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Please input the product ID to delete:");
                        string ID = Console.ReadLine();
                        Product.exportProductData(Product.deleteProduct(dataTable, ID));
                        break;
                    }
                case 4:
                    {
                        Product.searchProduct(dataTable);
                        break;
                    }
                case 5:
                    {
                        mainMenu();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please press a valid number!");
                        break;
                    }
            }
            mainMenu();
        }
        public static void categoriesPage()
        {
            category[] dataTable = Categories.dataTableCategory();
            Categories.exportCategoriesData(dataTable);

            Console.WriteLine("What would you like to do? (Press number)");
            Console.WriteLine("1. Add a Category");
            Console.WriteLine("2. Edit a Category");
            Console.WriteLine("3. Delete a Category");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Back to main menu");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    {
                        category newCategory = Categories.addCategory("New category:");
                        dataTable = Categories.updateDataTableCategory(dataTable, newCategory);
                        Console.WriteLine("Category added successfully!");
                        Categories.exportCategoriesData(dataTable);
                        break;
                    }
                case 2:
                    {
                        Categories.editCategory(dataTable);
                        Console.WriteLine("Category updated successfully!");
                        Categories.exportCategoriesData(dataTable);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Please input the category ID to delete:");
                        string ID = Console.ReadLine();
                        Categories.exportCategoriesData(Categories.deleteCategory(dataTable, ID));
                        break;
                    }
                case 4:
                    {
                        Categories.searchCategory(dataTable);
                        break;
                    }
                case 5:
                    {
                        mainMenu();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please press a valid number!");
                        break;
                    }
            }
            mainMenu();


        }
        public static void aboutPage()
        {
            Console.WriteLine("Inventory Management Version 1.0");
            Console.WriteLine("Copyright 2021 Loc Pham - HCMUS Student");
            Console.WriteLine();
            

            while (true)
            {
                Console.WriteLine("Press B to return to main menu");
                string button = Console.ReadLine();
                if (button.ToLower() == "b")
                {
                    mainMenu();
                    break;
                }
                else
                {
                    continue;
                }
            }
        }     
    }
}
