-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Апр 27 2023 г., 20:28
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `comp`
--

-- --------------------------------------------------------

--
-- Структура таблицы `blockdesign`
--

CREATE TABLE IF NOT EXISTS `blockdesign` (
  `name` varchar(50) NOT NULL,
  `form` varchar(50) NOT NULL,
  `parameter` varchar(50) NOT NULL,
  `value` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `blockdesign`
--

INSERT INTO `blockdesign` (`name`, `form`, `parameter`, `value`) VALUES
('AuthPanel', 'AuthPanel', 'WIDTH', '1155'),
('AuthPanel', 'AuthPanel', 'HEIGHT', '55'),
('treeView1', 'tableLayoutPanel1', 'WIDTH', '300'),
('treeView1', 'tableLayoutPanel1', 'HEIGHT', '493'),
('CopyRightUserControl', 'CopyRightUserControl', 'WIDTH', '1447'),
('CopyRightUserControl', 'CopyRightUserControl', 'HEIGHT', '40'),
('CopyRightUserControl', 'CopyRightUserControl', 'VK', '1'),
('CopyRightUserControl', 'CopyRightUserControl', 'WWW', '1');

-- --------------------------------------------------------

--
-- Структура таблицы `cities`
--

CREATE TABLE IF NOT EXISTS `cities` (
  `Name` varchar(60) NOT NULL,
  PRIMARY KEY (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `cities`
--

INSERT INTO `cities` (`Name`) VALUES
('Астрахань'),
('Минск'),
('Москва'),
('Мурманск'),
('Новгород'),
('Самара'),
('Санкт-Петербург'),
('Саратов'),
('Ульяновск'),
('Ярославль');

-- --------------------------------------------------------

--
-- Структура таблицы `defaultdesign`
--

CREATE TABLE IF NOT EXISTS `defaultdesign` (
  `type` varchar(60) NOT NULL,
  `parameter` varchar(60) NOT NULL,
  `value` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `defaultdesign`
--

INSERT INTO `defaultdesign` (`type`, `parameter`, `value`) VALUES
('System.Windows.Forms.Button', 'COLOR', '-8323073'),
('System.Windows.Forms.Label', 'FONT', 'Times New Roman;12'),
('System.Windows.Forms.Label', 'FONT_COLOR', '-65281'),
('System.Windows.Forms.Button', 'FONT', 'Times New Roman;14,25'),
('System.Windows.Forms.Button', 'FONT_COLOR', '-65536'),
('System.Windows.Forms.TextBox', 'FONT', 'Times New Roman;12'),
('System.Windows.Forms.TextBox', 'FONT_COLOR', '-65536'),
('System.Windows.Forms.Panel', 'COLOR', '-65');

-- --------------------------------------------------------

--
-- Структура таблицы `level1`
--

CREATE TABLE IF NOT EXISTS `level1` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `id_main` int(11) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `Image` varchar(200) NOT NULL,
  `Specs` varchar(200) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Дамп данных таблицы `level1`
--

INSERT INTO `level1` (`ID`, `id_main`, `Name`, `Image`, `Specs`, `Quantity`, `Price`) VALUES
(1, 1, 'ПК DEXP Atlas H341', 'ПК DEXP Atlas H341.jpg', '', 2, 1000),
(2, 2, '21.5" Мониторы', 'Monitor_21.jpg', '', 3, 3000),
(3, 3, 'Клавиатуры проводные', 'Keybord_wired.jpg', '', 2, 100),
(4, 4, 'Мыши проводные', 'Mouse_wired.jpg', '', 3, 100),
(5, 1, 'ПК Sharkoon DG7000-G', 'sharkoon_dg7000_g_5.jpg', '', 2, 2000),
(6, 2, '19.5" Мониторы', 'Monitor_19.jpg', '', 0, 0),
(7, 4, 'Мыши беспроводные', 'Mouse_wireless.jpg', '', 0, 0),
(8, 3, 'Клавиатуры беспроводные', 'Keybord_wireless.jpg', '', 0, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `level2`
--

CREATE TABLE IF NOT EXISTS `level2` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `id_main` int(11) NOT NULL,
  `id_level1` int(11) NOT NULL,
  `Name` varchar(80) NOT NULL,
  `Image` varchar(40) NOT NULL,
  `Specs` varchar(400) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `kod` varchar(20) NOT NULL,
  `link` varchar(300) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=15 ;

--
-- Дамп данных таблицы `level2`
--

INSERT INTO `level2` (`ID`, `id_main`, `id_level1`, `Name`, `Image`, `Specs`, `Quantity`, `Price`, `kod`, `link`) VALUES
(1, 1, 1, 'Процессор Intel Core i5 12400F OEM', 'DSF201.jpg', '', 1, 15600, '100031046210', ''),
(2, 4, 7, 'Aceline WM-907BU', 'Aceline WM-907BU.jpg', '', 10, 299, '', ''),
(4, 4, 7, 'Defender Hit MM-495', 'Defender Hit MM-495.jpg', '', 10, 299, '', ''),
(5, 4, 7, 'Gembird MUSW-111-GRN зеленый', 'Gembird MUSW-111-GRN зеленый.jpg', '', 10, 299, '', ''),
(6, 4, 7, 'Gembird MUSW-265', 'Gembird MUSW-265.jpg', '', 10, 299, '', ''),
(8, 1, 1, 'ASRock H510M-HVS', 'ASRock H510M-HVS.jpg', '', 12, 5200, '', ''),
(9, 1, 1, 'GIGABYTE GeForce RTX 3050 EAGLE', 'GIGABYTE GeForce RTX 3050 EAGLE.jpg', '', 2, 25999, '', ''),
(10, 1, 1, 'Patriot Signature Line', 'Patriot Signature Line.jpg', '', 1, 2999, '', ''),
(11, 1, 1, '240 ГБ 2.5" SATA накопитель Kingston A400', '240 ГБ 2.5 SATA Kingston A400.jpg', '', 1, 1750, '', ''),
(12, 1, 5, 'Intel Core i3-10105F', 'Intel Core i3-10105F.jpg', '', 2, 5599, '', ''),
(13, 1, 5, 'GIGABYTE H470M K', 'GIGABYTE H470M K.jpg', '', 2, 5199, '', ''),
(14, 1, 5, 'MSI GeForce GTX 1630 VENTUS XS', 'MSI GeForce GTX 1630 VENTUS XS.jpg', '', 5, 12999, '', '');

-- --------------------------------------------------------

--
-- Структура таблицы `main`
--

CREATE TABLE IF NOT EXISTS `main` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(40) NOT NULL,
  `Image` varchar(80) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Дамп данных таблицы `main`
--

INSERT INTO `main` (`ID`, `Name`, `Image`) VALUES
(1, 'Системный блок ПК', 'Tower.jpg'),
(2, 'Монитор', 'Monitor.jpg'),
(3, 'Клавиатура', 'Keybord.jpg'),
(4, 'Мышь', 'Mouse.jpg');

-- --------------------------------------------------------

--
-- Структура таблицы `uniquedesign`
--

CREATE TABLE IF NOT EXISTS `uniquedesign` (
  `type` varchar(100) NOT NULL,
  `name` varchar(50) NOT NULL,
  `form` varchar(50) NOT NULL,
  `parameter` varchar(50) NOT NULL,
  `value` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `uniquedesign`
--

INSERT INTO `uniquedesign` (`type`, `name`, `form`, `parameter`, `value`) VALUES
('System.Windows.Forms.Button', 'AccountButton', 'MainForm', 'COLOR', '-128'),
('System.Windows.Forms.Button', 'AccountButton', 'MainForm', 'FONT', 'Times New Roman;12'),
('System.Windows.Forms.Button', 'AccountButton', 'MainForm', 'FONT_COLOR', '-16744448'),
('System.Windows.Forms.Button', 'AuthButton', 'MainForm', 'LOCATION', '626, 15'),
('System.Windows.Forms.Button', 'AuthButton', 'MainForm', 'SIZE', '83, 30'),
('System.Windows.Forms.Button', 'AdminPanelButton', 'MainForm', 'LOCATION', '728, 15'),
('System.Windows.Forms.Button', 'AdminPanelButton', 'MainForm', 'SIZE', '222, 30'),
('System.Windows.Forms.Button', 'AccountButton', 'MainForm', 'LOCATION', '960, 15'),
('System.Windows.Forms.Button', 'AccountButton', 'MainForm', 'SIZE', '150, 30'),
('System.Windows.Forms.Button', 'DesignButton', 'MainForm', 'LOCATION', '1115, 15'),
('System.Windows.Forms.Button', 'DesignButton', 'MainForm', 'SIZE', '116, 30'),
('System.Windows.Forms.Button', 'DesignButton', 'MainForm', 'ADMIN', '1'),
('System.Windows.Forms.Button', 'AccountButton', 'MainForm', 'ADMIN', '0'),
('System.Windows.Forms.Label', 'HelloLabel', 'MainForm', 'FONT', 'Arial Narrow;14,25'),
('System.Windows.Forms.Label', 'HelloLabel', 'MainForm', 'FONT_COLOR', '-65536'),
('System.Windows.Forms.Label', 'label1', 'MainForm', 'FONT', 'Times New Roman;12'),
('System.Windows.Forms.Label', 'label1', 'MainForm', 'FONT_COLOR', '-65536');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `Name` varchar(20) NOT NULL,
  `Surname` varchar(20) NOT NULL,
  `City` varchar(60) NOT NULL,
  `Age` int(11) NOT NULL,
  `Login` varchar(10) NOT NULL,
  `Password` varchar(10) NOT NULL,
  `Email` varchar(20) NOT NULL,
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `admin_id` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`Name`, `Surname`, `City`, `Age`, `Login`, `Password`, `Email`, `ID`, `admin_id`) VALUES
('Сергей', 'Поврозюк', 'Ульяновск', 47, 'povser', '123456', 'povser@yandex.ru', 1, 1),
('Иван', 'Иванов', 'Москва', 20, 'ivan', '123', 'ivanoff@mail.ru', 2, 0),
('Петр', 'Петров', 'Москва', 25, 'petr', '123', 'petr@mail.ru', 3, 0),
('Василий', 'Васильев', 'Минск', 34, 'vasya', '123', 'vasya@mail.ru', 4, 0),
('Вася', 'Петров', 'Самара', 23, 'petrvasya', '123', 'petrvasya@mail.ru', 5, 0),
('Михаил', 'Майков', 'Москва', 13, 'Miki', '123', 'Mikki123@yandex.ru', 6, 0),
('Михаил', 'Мишин', 'Астрахань', 15, 'Mik', '123', 'Mik1@mail.ru', 7, 0),
('Андрей', 'Андреев', 'Ярославль', 22, 'Andy', '123', 'andy@mail.ru', 8, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
