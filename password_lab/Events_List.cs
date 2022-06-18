using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_lab
{
    //для журнала событий:
    /*
     * Запуск приложения -- время
     * Завершение приложения -- время
     * Введен логин: @login -- @статус -- время
     * Попытка входа -- введен пароль: @password -- @статус -- время
     * Смена пароля -- пользователь: @user -- @статус -- время
     * Создание пользователя -- пользователь: @user -- @статус -- время
     */
    public class Events_List
    {
        string path;
        public Events_List(string path)
        {
            this.path = path;
            if (!File.Exists(path))
            {
                using (StreamWriter writer = File.AppendText(path))
                {
                    writer.WriteLine(addDate("Начало аудита событий"));
                }
            }
        }
        public List<string> getAllListEvents()
        {
            var list_events = new List<string>(File.ReadAllText(path).Split('\n'));
            list_events.Reverse();
            return list_events;
        }
        public string getAllEvents()
        {
            return getAllListEvents().Aggregate((el1, el2) => el1 + "\n" + el2);
        }

        public enum App { START, END }
        public enum Status { OK, NO, NOT_EXISTS }


        public string adminChangeData(string login)
        {
            string result = addDate("Админ внес изменения данные пользователя " + login);
            writeEvent(result);
            return result;
        }
        public string workApp(App status)
        {
            string proc = status == App.START? "Запуск": "Завершение";
            string result = addDate(proc + " приложения");
            writeEvent(result);
            return result;
        }

        public string blockingLogin(string login, Status st)
        {
            string status = st == Status.OK ? "заблокирован" : "разблокирован";
            string result = addDate("Пользователь: " + login
                                                + " -- " + status);
            writeEvent(result);
            return result;
        }
        public string logout(string login)
        {
            string result = addDate("Выход из аккаунта -- пользователь: " + login);
            writeEvent(result);
            return result;
        }

        public string inputLogin(string login, Status st)
        {
            string statuc = st == Status.OK ? "успех" : 
                                st == Status.NOT_EXISTS? "не существует": "заблокирован";
            string result = addDate("Введен логин: " + login);
            writeEvent(result);
            return result;
        }
        
        public string inputPassword(string password, Status st)
        {
            string status = st == Status.OK ? "Успех" : "Неверный пароль";
            string result = addDate("Попытка входа -- введен пароль: " + password
                                + " -- " + status);
            writeEvent(result);
            return result;
        }

        public string changePassword(string login, Status st)
        {
            string status = st == Status.OK ? "Успех" : "Отклонено";
            string result = addDate("Смена пароля -- пользователь: " 
                                        + login + " -- " + status);
            writeEvent(result);
            return result;
        }

        public string createUser(string login, Status st)
        {
            string status = st == Status.OK ? "Успех" : "Отклонено";
            string result = addDate("Создание пользователя -- пользователь: " 
                                        + login + " -- " + status);
            writeEvent(result);
            return result;
        }
        private void writeEvent(string evnt)
        {
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine(evnt);
            }
        }

        private string addDate(string str)
        {
            return str + " -- " + DateTime.Now;
        }
    }
}
