using System;
using System.IO;
using System.Collections.Generic;

namespace TodoList
{
    class Program
    {
        static int Main(string[] args)
        {
            List<Todoitem> todoList = new List<Todoitem>();
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName;

            try{
                string[] todoFile = File.ReadAllLines(@filePath);

                foreach(string line in todoFile){
                    todoList.Add(line);
                }
            } catch(IOException e){
                Console.WriteLine(e.Message);
                return -1;
            }

            int count = 1;
            foreach (string item in todoList)
            {
                System.Console.WriteLine($"count: {count}, {item}");
                count++;
            }
            return 0;

        }
        static List<Todoitem> initList(string filePath){
            
            
            try{
                string[] todoFile = File.ReadAllLines(@filePath);

                foreach(string line in todoFile){
                    string[] itens = line.Split(",");
                    string titulo = itens[0].Replace("\"","");
                    string note = itens[1].Replace("\"","");
                    Todoitem todoitem = new Todoitem(titulo,nota);
                    TodoList.add(todoitem);
                }
            } catch(IOException e){
                Console.WriteLine("Erro de acesso.");
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
}  