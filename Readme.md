﻿### Итоговая работа

Для решения поставленной задачи, я выбрала решение, состоящее из слудующих пунктов:

1. **GetIntialArray**

     а. Генерация тестового текста взятого на сайте https://www.lipsum.com/.

     б. Создание изначального массива путем удаления всех знаков препинания из сгенерированного текста
и разбиение его по словам.

2. **FilterArray**

     а. Подсчет колличества элементов массива, соответствующих критерию: длина строки меньше заданного параметра, с инкрементарным присовением этого количества переменной **count** .

     б. Паралельно с пунктом *2.а* заполняется **tempArray** индексами элементов, соответветствующих тому же критерию.

     в. После этого идет второй цикл, в котором элементы исходного массива с индексами из **tempArray** копируются в результирующий массив.


3. **Main**

     а. Последовательный вызов **GetIntialArray** и **FilterArray**

     б. Вывод полученного массива в виде строки.



