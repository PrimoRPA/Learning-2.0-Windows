# Данные

Элементы для обработки и преобразования данных: строки, даты, таблицы (DataTable), а также конвертация HTML/JSON/XML, изображений и архивов. Раздел разбит на подпапки по типу данных — ниже подсказка, в какую подпапку идти в зависимости от задачи.

> 📖 Общая навигация по репозиторию — в [README главной страницы](../../README.md).

## 📂 Подпапки — что выбрать по задаче

| Подпапка | Для чего нужен | Кол-во элементов |
| :--- | :--- | :--- |
| [📁 **HTML**](https://github.com/PrimoRPA/Learning-2.0-Windows/tree/main/1.%20%D0%A0%D0%B5%D0%B6%D0%B8%D0%BC_%D0%9F%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D1%8C/%D0%94%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5/HTML) | Нужно разобрать HTML, полученный не со страницы сайта (из письма, файла, API) | 2 |
| [📁 **JSON**](https://github.com/PrimoRPA/Learning-2.0-Windows/tree/main/1.%20%D0%A0%D0%B5%D0%B6%D0%B8%D0%BC_%D0%9F%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D1%8C/%D0%94%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5/JSON) | Нужно обменяться данными с API или другой системой в формате JSON | 2 |
| [📁 **XML**](https://github.com/PrimoRPA/Learning-2.0-Windows/tree/main/1.%20%D0%A0%D0%B5%D0%B6%D0%B8%D0%BC_%D0%9F%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D1%8C/%D0%94%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5/XML) | Система-партнёр общается только через XML (1С, госреестры, старые интеграции) | 3 |
| [📁 **Архивирование**](https://github.com/PrimoRPA/Learning-2.0-Windows/tree/main/1.%20%D0%A0%D0%B5%D0%B6%D0%B8%D0%BC_%D0%9F%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D1%8C/%D0%94%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5/%D0%90%D1%80%D1%85%D0%B8%D0%B2%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5) | Нужно упаковать результат в архив или распаковать входящий файл | 2 |
| [📁 **Дата**](https://github.com/PrimoRPA/Learning-2.0-Windows/tree/main/1.%20%D0%A0%D0%B5%D0%B6%D0%B8%D0%BC_%D0%9F%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D1%8C/%D0%94%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5/%D0%94%D0%B0%D1%82%D0%B0) | Нужно посчитать срок, разницу дат или привести дату к нужному формату | 6 |
| [📁 **Изображения**](https://github.com/PrimoRPA/Learning-2.0-Windows/tree/main/1.%20%D0%A0%D0%B5%D0%B6%D0%B8%D0%BC_%D0%9F%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D1%8C/%D0%94%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5/%D0%98%D0%B7%D0%BE%D0%B1%D1%80%D0%B0%D0%B6%D0%B5%D0%BD%D0%B8%D1%8F) | Нужно повернуть/подготовить изображение перед распознаванием или отправкой | 4 |
| [📁 **Маппинг**](https://github.com/PrimoRPA/Learning-2.0-Windows/tree/main/1.%20%D0%A0%D0%B5%D0%B6%D0%B8%D0%BC_%D0%9F%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D1%8C/%D0%94%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5/%D0%9C%D0%B0%D0%BF%D0%BF%D0%B8%D0%BD%D0%B3) | Нужно передать много переменных одним аргументом в другой процесс | 2 |
| [📁 **Строки**](https://github.com/PrimoRPA/Learning-2.0-Windows/tree/main/1.%20%D0%A0%D0%B5%D0%B6%D0%B8%D0%BC_%D0%9F%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D1%8C/%D0%94%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5/%D0%A1%D1%82%D1%80%D0%BE%D0%BA%D0%B8) | Нужно найти, заменить, разбить или проверить формат текста | 9 |
| [📁 **Таблицы**](https://github.com/PrimoRPA/Learning-2.0-Windows/tree/main/1.%20%D0%A0%D0%B5%D0%B6%D0%B8%D0%BC_%D0%9F%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D1%8C/%D0%94%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5/%D0%A2%D0%B0%D0%B1%D0%BB%D0%B8%D1%86%D1%8B) | Нужно создать, отсортировать, отфильтровать или объединить DataTable | 10 |
