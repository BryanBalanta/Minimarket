-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-11-2023 a las 18:04:09
-- Versión del servidor: 10.4.17-MariaDB
-- Versión de PHP: 7.4.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_minimarket`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE `categoria` (
  `idCategoria` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `descripcion` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`idCategoria`, `nombre`, `descripcion`) VALUES
(1, 'Bebida', 'Jugo hit');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL,
  `tipoDocumento` enum('CC','TI','PAS','PEP','PPT','CE','Otro') DEFAULT NULL,
  `identificacion` varchar(11) NOT NULL,
  `nombres` varchar(50) NOT NULL,
  `apellidos` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `celular` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`idCliente`, `tipoDocumento`, `identificacion`, `nombres`, `apellidos`, `correo`, `celular`) VALUES
(1, 'CC', '1123657897', 'Danilo', 'Perez', 'danilo123@gmail.com', '3103449876');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `minimarket`
--

CREATE TABLE `minimarket` (
  `idMiniMarket` int(11) NOT NULL,
  `nit` varchar(50) NOT NULL,
  `razonSocial` varchar(50) NOT NULL,
  `telefono` varchar(10) NOT NULL,
  `nomenclatura` varchar(50) NOT NULL,
  `ciudad` varchar(50) NOT NULL,
  `departamento` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `sitioWeb` varchar(50) NOT NULL,
  `facebook` varchar(50) NOT NULL,
  `whatsapp` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `minimarket`
--

INSERT INTO `minimarket` (`idMiniMarket`, `nit`, `razonSocial`, `telefono`, `nomenclatura`, `ciudad`, `departamento`, `correo`, `sitioWeb`, `facebook`, `whatsapp`) VALUES
(1, '123456789', 'Ctrl+buy', '3119645512', 'Cra 5 # 5-8', 'Cali', 'Valle del Cauca', 'Ctrl+buy@gmail.com', 'www.Ctrl+buy.com', 'facebook.com/Ctrl+buy', '3119645512');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `idProveedor` int(11) NOT NULL,
  `Nit` varchar(10) NOT NULL,
  `razonSocial` varchar(50) NOT NULL,
  `telefono` varchar(10) NOT NULL,
  `nomenclatura` varchar(50) NOT NULL,
  `ciudad` varchar(50) NOT NULL,
  `departamento` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`idProveedor`, `Nit`, `razonSocial`, `telefono`, `nomenclatura`, `ciudad`, `departamento`, `correo`) VALUES
(1, '123654897', 'Vallecito del Sol', '3105215269', 'Calle 50 # 10-15', 'Cali', 'Valle del Cauca', 'vallecitodelsol@gmail.com'),
(2, '123659863', 'JugoFlecha', '3123457896', 'Cra 35 # 50-52', 'Cali', 'Valle del Cauca', 'JugoFlecha@gmail.com'),
(3, '135698657', 'Crokantes', '3153559865', 'Calle 10 # 80-82', 'Cali', 'Valle del Cauca', 'Crokantes@gmail.com');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`idCategoria`),
  ADD UNIQUE KEY `unico_nombre` (`nombre`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idCliente`),
  ADD UNIQUE KEY `unico_identificacion` (`identificacion`);

--
-- Indices de la tabla `minimarket`
--
ALTER TABLE `minimarket`
  ADD PRIMARY KEY (`idMiniMarket`),
  ADD UNIQUE KEY `unico_nit` (`nit`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`idProveedor`),
  ADD UNIQUE KEY `unico_nit_proveedor` (`Nit`),
  ADD UNIQUE KEY `unico_razonSocial_proveedor` (`razonSocial`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `categoria`
--
ALTER TABLE `categoria`
  MODIFY `idCategoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `minimarket`
--
ALTER TABLE `minimarket`
  MODIFY `idMiniMarket` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `idProveedor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
