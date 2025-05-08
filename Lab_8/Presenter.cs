using Lab_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    // Абстрактный класс, который предоставляет статические методы для управления данными.
    public class Presenter
    {
        // Приватное статическое поле для работы с логикой обработки данных.
        private Service _service;

        //Представление
        private Form1 _form;

        public Presenter(Form1 form)
        {
            _service = new Service();
            _form = form;
        }

        // Возвращает коллекцию данных (список интернет операторов) из сервиса.
        public InternerOperatorList getDataBase()
        {
            return _service._dataBase;
        }

        // Добавляет новую запись в коллекцию данных после проверки её корректности.
        public void add(String inputData)
        {
            _service.checkData(inputData);
            _service.add(inputData);
            _form.updateData(getDataBase());
        }

        // Обновляет существующую запись в коллекции данных. 
        public void update(String inputData)
        {
            InternetOperator localOperator = _service.convert(inputData);
            _service.checkPrice(localOperator.PriceOfMonth.ToString());
            _service.checkUsers(localOperator.CntUsers.ToString());
            _service.update(inputData);
        }

        // Удаляет запись из коллекции данных по имени. 
        public void remove(String name)
        {
            _service.checkSelection(name);
            _service.remove(name);
        }

        // Возвращает объект из коллекции данных по имени. 
        public Tuple<decimal, int> get(String name)
        {
            _service.checkName(name);
            InternetOperator localOperator =  _service.get(name);
            return new Tuple<decimal, int>
                (localOperator.PriceOfMonth, localOperator.CntUsers);
        }

    }
}