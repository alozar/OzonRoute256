﻿# E. Отчет (15 баллов)
> **ограничение по времени на тест:** 2 секунда  
> **ограничение по памяти на тест:** 512 мегабайт  
> **ввод:** стандартный ввод  
> **вывод:** стандартный вывод

## Условия
Директор IT-корпорации оценивает эффективность работы сотрудников по различным показателям и критериям.

Один из этих критериев сформулирован следующим образом: приступив к некоторому заданию,
сотрудник должен завершить его, не переключаясь на другие задания.

Чтобы проверить сотрудников на соответствие этому критерию, директор потребовал от каждого сотрудника отчет о том,
какие задания он выполнял в последние n дней.

Отчет — это последовательность из n целых чисел a₁,a₂,…,aₙ, где ai — идентификатор задания,
которое сотрудник выполнял в i-й день.

Вам необходимо написать программу, проверяющую, соответствует ли сотрудник критерию по его отчету.

Сотрудник соответствует этому критерию, если не существует такого задания x, которое выполнялось с перерывом
(т. е. в некоторый день i сотрудник выполнял задание x, в дни с i+1 по j−1 он занимался другими заданиями,
а в день j сотрудник продолжил выполнение задания x, при этом j>i+1).

Иными словами, каждое задание, которое выполнял сотрудник, должно занимать один непрерывный отрезок дней.

## Входные данные
*В первой строке задано одно целое число **t (1 ≤ t ≤ 10)** — количество наборов входных данных.*

*Каждый набор входных данных состоит из двух строк.
В первой строке задано одно целое число **n (3 ≤ n ≤ 50000)**.
Во второй строке заданы **n** целых чисел **a₁,a₂,…,aₙ (1 ≤ ai ≤ n)** — отчет сотрудника.*  

## Выходные данные
*Для каждого набора входных данных выведите ответ на отдельной строке. Если отчет соответствует критерию, выведите **YES**, иначе выведите **NO**.*  

## Пример
```plaintext
входные данные
5
5
1 2 3 4 5
4
1 2 3 1
8
2 3 4 8 5 5 5 5
5
1 1 3 2 2
5
1 1 2 3 2
```
```plaintext
выходные данные
YES
NO
YES
YES
NO
```