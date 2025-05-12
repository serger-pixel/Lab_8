using Lab_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    // Класс, который предоставляет методы для управления данными.
    public class Presenter
    {
        // Приватное поле для работы с логикой обработки данных.
        private Service _service;

        //Представление
        private Form1 _form;

        public Presenter(Form1 form)
        {
            _service = new Service();
            _form = form;
        }

        // Возвращает коллекцию данных (список имён интернет операторов) из сервиса.
        public List<String> getData()
        {
            List<String> data = new List<String>();
            foreach (var el in _service._dataBase) 
            {
                data.Add(el.NameOperator);
            }
            return data;
        }

        // Добавляет новую запись в коллекцию данных после проверки её корректности.
        public void add(String inputData)
        {
            _service.checkData(inputData);
            _service.add(inputData);
            _form.updateData(getData());
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