## Задача

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение

- Функция `EnteringDataIntoAnArray` принимает в качестве параметра длину массива `int`, который задает пользователь и возвращает массив строк, который вводит пользователь в цикле `for`.
- Функция `SortedArray` принимает в качестве параметра массив строк и перебирает его два раза циклом `for`. В первом цикле считается количество элеметов, длина которых меньше или равна 3м. Во втором цикле идет заполнение нового массива элементами, удовлетворяющим условию. Данный массив возвращается функцией.
- Функция `PrintArray` выводит в консоль массив.