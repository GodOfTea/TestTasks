﻿/* Doc */
/*
    Задача: выполнить тестовое
    
    1. Нажатие на любое место на сцене, instantiate объекта (случайного) (done)
    2. Нажатие на сам объект, смена цвета (случаного, но определенного)
    3. Нажатие на сам объект, увеличение счетчика кликов объекта

    1. Тест будет проходить в рантайме
    2. Нужны script. object для цветов (done)
    3. Нужен канвас с данными об объектах

    Логика работы с цветом:
        1. При появлении объекта, начинается таймер для этого объекта
        2. Через n время, объект сам меняет цвет
        3. Если на объект нажать, он принудительно меняет цвет

        Бесконечно

    Цвета:
        --------------------------------------------------------------------------------
        № | Цвет    | Клики: Куб | Клики: Сфера | Клики: Капусла | RGB                  |
        1 | Красный |          1 |            2 |              4 | R: 255 G: 0   B: 0   |
        2 | Синий   |          2 |            4 |              6 | R: 0   G: 0   B: 255 |
        3 | Желтый  |          4 |            6 |              8 | R: 255 G: 255 B: 0   |
        4 | Серый   |          6 |            8 |             10 | R: 190 G: 190 B: 190 |
        5 | Черный  |          8 |           10 |              1 | R: 0   G: 0   B: 0   |
        6 | Розовый |         10 |            1 |              2 | R: 255 G: 192 B: 203 |
        ---------------------------------------------------------------------------------
*/