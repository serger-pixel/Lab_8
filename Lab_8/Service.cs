﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Service
    {
        //Регулярные выражения для проверки полей интернет операторов
        Regex _regexName = new Regex(Regs._nameReg);
        Regex _regexPrice = new Regex(Regs._priceReg);
        Regex _regexUsers = new Regex(Regs._cntUsersReg);

        //Список интернет операторов
        public volatile InternerOperatorList _dataBase = new InternerOperatorList();

        public void checkName(String name)
        {
            if (!_regexName.Match(name).Success)
            {
                throw new NameException();
            }
        }

        //Проверка выбора интернет операторов
        public void checkSelection(String name)
        {
            if (name.Length == 0)
            {
                throw new ObjectNotChosenException();
            }
        }

        //Проверка существования интернет оператора
        public void checkExistance(String name)
        {
            if (_dataBase.find(name))
            {
                throw new ObjectExists();
            }
        }

        //Проверка цены
        public void checkPrice(String price)
        {
            if (!_regexPrice.Match(price).Success)
            {
                throw new PriceException();
            }
        }

        //Проверка кол-ва пользователей
        public void checkUsers(String cntUsers)
        {
            if (!_regexUsers.Match(cntUsers).Success)
            {
                throw new CntUsersException();
            }
        }

        //Проверка входящей информации
        public void checkData(String inputData)
        {
            String[] splitData = inputData.Split(new char[] { ' ' });

            checkName(splitData[0]);
            checkExistance(splitData[0]);
            checkPrice(splitData[1]);
            checkUsers(splitData[2]);
        }

        //Конвертация строки в интернет оператор
        public InternetOperator convert(String inputData)
        {
            String[] splitData = inputData.Split(new char[] { ' ' });
            return new InternetOperator(splitData[0], decimal.Parse(splitData[1]), int.Parse(splitData[2]));
        }

        //Добавление интернет оператора
        public void add(String inputData)
        {
            _dataBase.Add(convert(inputData));
        }

        //Удаление пользователя
        public void remove(String name)
        {
            InternetOperator localOperator = _dataBase.getByName(name);
            _dataBase.Remove(localOperator);
        }

        //Получение пользователя
        public InternetOperator get(String name)
        {
            return _dataBase.getByName(name);
        }

        //Обновление пользователя
        public void update(String inputData)
        {
            InternetOperator localOperator = convert(inputData);
            InternetOperator innerOper = _dataBase.getByName(localOperator.NameOperator);
            innerOper.PriceOfMonth = localOperator.PriceOfMonth;
            innerOper.CntUsers = localOperator.CntUsers;
        }
    }
}
