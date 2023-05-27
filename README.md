USE [master]
GO
CREATE DATABASE [TuriDemo]
GO
USE [TuriDemo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[Code] [nchar](2) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 27.05.2023 16:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CountOfStars] [int] NOT NULL,
	[CountryCode] [nchar](2) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelComment]    Script Date: 27.05.2023 16:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelComment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[Author] [nvarchar](100) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_HotelComment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelImage]    Script Date: 27.05.2023 16:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelImage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NOT NULL,
	[ImageSource] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_HotelImage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelOfTour]    Script Date: 27.05.2023 16:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelOfTour](
	[HotelId] [int] NOT NULL,
	[TourId] [int] NOT NULL,
 CONSTRAINT [PK_HotelOfTour] PRIMARY KEY CLUSTERED 
(
	[HotelId] ASC,
	[TourId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tour]    Script Date: 27.05.2023 16:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tour](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketCount] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ImagePreview] [varbinary](max) NULL,
	[Price] [money] NOT NULL,
	[IsActual] [bit] NOT NULL,
 CONSTRAINT [PK_Tour] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 27.05.2023 16:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfTour]    Script Date: 27.05.2023 16:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfTour](
	[TourId] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
 CONSTRAINT [PK_TypeOfTour] PRIMARY KEY CLUSTERED 
(
	[TourId] ASC,
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AD', N'Andorra')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AE', N'United Arab Emirates')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AF', N'Afghanistan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AG', N'Antigua and Barbuda')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AI', N'Anguilla')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AL', N'Albania')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AM', N'Armenia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AN', N'Netherlands Antilles')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AO', N'Angola')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AQ', N'Antarctica')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AR', N'Argentina')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AS', N'American Samoa')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AT', N'Austria')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AU', N'Australia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AW', N'Aruba')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AX', N'Aland Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'AZ', N'Azerbaijan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BA', N'Bosnia and Herzegovina')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BB', N'Barbados')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BD', N'Bangladesh')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BE', N'Belgium')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BF', N'Burkina Faso')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BG', N'Bulgaria')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BH', N'Bahrain')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BI', N'Burundi')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BJ', N'Benin')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BL', N'Saint BarthГ©lemy')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BM', N'Bermuda')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BN', N'Brunei')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BO', N'Bolivia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BQ', N'Bonaire, Saint Eustatius and Saba ')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BR', N'Brazil')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BS', N'Bahamas')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BT', N'Bhutan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BV', N'Bouvet Island')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BW', N'Botswana')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BY', N'Belarus')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'BZ', N'Belize')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CA', N'Canada')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CC', N'Cocos Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CD', N'Democratic Republic of the Congo')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CF', N'Central African Republic')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CG', N'Republic of the Congo')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CH', N'Switzerland')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CI', N'Ivory Coast')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CK', N'Cook Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CL', N'Chile')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CM', N'Cameroon')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CN', N'China')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CO', N'Colombia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CR', N'Costa Rica')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CS', N'Serbia and Montenegro')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CU', N'Cuba')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CV', N'Cape Verde')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CW', N'CuraГ§ao')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CX', N'Christmas Island')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CY', N'Cyprus')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'CZ', N'Czech Republic')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'DE', N'Germany')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'DJ', N'Djibouti')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'DK', N'Denmark')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'DM', N'Dominica')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'DO', N'Dominican Republic')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'DZ', N'Algeria')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'EC', N'Ecuador')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'EE', N'Estonia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'EG', N'Egypt')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'EH', N'Western Sahara')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'ER', N'Eritrea')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'ES', N'Spain')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'ET', N'Ethiopia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'FI', N'Finland')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'FJ', N'Fiji')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'FK', N'Falkland Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'FM', N'Micronesia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'FO', N'Faroe Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'FR', N'France')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GA', N'Gabon')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GB', N'United Kingdom')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GD', N'Grenada')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GE', N'Georgia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GF', N'French Guiana')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GG', N'Guernsey')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GH', N'Ghana')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GI', N'Gibraltar')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GL', N'Greenland')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GM', N'Gambia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GN', N'Guinea')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GP', N'Guadeloupe')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GQ', N'Equatorial Guinea')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GR', N'Greece')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GS', N'South Georgia and the South Sandwich Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GT', N'Guatemala')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GU', N'Guam')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GW', N'Guinea-Bissau')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'GY', N'Guyana')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'HK', N'Hong Kong')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'HM', N'Heard Island and McDonald Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'HN', N'Honduras')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'HR', N'Croatia')
GO
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'HT', N'Haiti')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'HU', N'Hungary')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'ID', N'Indonesia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'IE', N'Ireland')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'IL', N'Israel')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'IM', N'Isle of Man')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'IN', N'India')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'IO', N'British Indian Ocean Territory')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'IQ', N'Iraq')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'IR', N'Iran')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'IS', N'Iceland')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'IT', N'Italy')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'JE', N'Jersey')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'JM', N'Jamaica')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'JO', N'Jordan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'JP', N'Japan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'KE', N'Kenya')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'KG', N'Kyrgyzstan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'KH', N'Cambodia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'KI', N'Kiribati')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'KM', N'Comoros')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'KN', N'Saint Kitts and Nevis')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'KP', N'North Korea')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'KR', N'South Korea')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'KW', N'Kuwait')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'KY', N'Cayman Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'KZ', N'Kazakhstan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'LA', N'Laos')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'LB', N'Lebanon')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'LC', N'Saint Lucia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'LI', N'Liechtenstein')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'LK', N'Sri Lanka')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'LR', N'Liberia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'LS', N'Lesotho')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'LT', N'Lithuania')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'LU', N'Luxembourg')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'LV', N'Latvia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'LY', N'Libya')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MA', N'Morocco')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MC', N'Monaco')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MD', N'Moldova')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'ME', N'Montenegro')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MF', N'Saint Martin')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MG', N'Madagascar')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MH', N'Marshall Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MK', N'Macedonia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'ML', N'Mali')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MM', N'Myanmar')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MN', N'Mongolia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MO', N'Macao')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MP', N'Northern Mariana Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MQ', N'Martinique')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MR', N'Mauritania')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MS', N'Montserrat')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MT', N'Malta')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MU', N'Mauritius')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MV', N'Maldives')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MW', N'Malawi')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MX', N'Mexico')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MY', N'Malaysia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'MZ', N'Mozambique')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'NA', N'Namibia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'NC', N'New Caledonia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'NE', N'Niger')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'NF', N'Norfolk Island')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'NG', N'Nigeria')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'NI', N'Nicaragua')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'NL', N'Netherlands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'NO', N'Norway')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'NP', N'Nepal')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'NR', N'Nauru')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'NU', N'Niue')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'NZ', N'New Zealand')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'OM', N'Oman')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PA', N'Panama')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PE', N'Peru')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PF', N'French Polynesia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PG', N'Papua New Guinea')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PH', N'Philippines')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PK', N'Pakistan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PL', N'Poland')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PM', N'Saint Pierre and Miquelon')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PN', N'Pitcairn')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PR', N'Puerto Rico')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PS', N'Palestinian Territory')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PT', N'Portugal')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PW', N'Palau')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'PY', N'Paraguay')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'QA', N'Qatar')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'RE', N'Reunion')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'RO', N'Romania')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'RS', N'Serbia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'RU', N'Russia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'RW', N'Rwanda')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SA', N'Saudi Arabia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SB', N'Solomon Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SC', N'Seychelles')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SD', N'Sudan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SE', N'Sweden')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SG', N'Singapore')
GO
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SH', N'Saint Helena')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SI', N'Slovenia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SJ', N'Svalbard and Jan Mayen')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SK', N'Slovakia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SL', N'Sierra Leone')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SM', N'San Marino')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SN', N'Senegal')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SO', N'Somalia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SR', N'Suriname')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SS', N'South Sudan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'ST', N'Sao Tome and Principe')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SV', N'El Salvador')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SX', N'Sint Maarten')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SY', N'Syria')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'SZ', N'Swaziland')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TC', N'Turks and Caicos Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TD', N'Chad')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TF', N'French Southern Territories')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TG', N'Togo')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TH', N'Thailand')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TJ', N'Tajikistan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TK', N'Tokelau')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TL', N'East Timor')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TM', N'Turkmenistan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TN', N'Tunisia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TO', N'Tonga')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TR', N'Turkey')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TT', N'Trinidad and Tobago')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TV', N'Tuvalu')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TW', N'Taiwan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'TZ', N'Tanzania')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'UA', N'Ukraine')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'UG', N'Uganda')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'UM', N'United States Minor Outlying Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'US', N'United States')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'UY', N'Uruguay')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'UZ', N'Uzbekistan')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'VA', N'Vatican')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'VC', N'Saint Vincent and the Grenadines')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'VE', N'Venezuela')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'VG', N'British Virgin Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'VI', N'U.S. Virgin Islands')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'VN', N'Vietnam')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'VU', N'Vanuatu')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'WF', N'Wallis and Futuna')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'WS', N'Samoa')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'XK', N'Kosovo')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'YE', N'Yemen')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'YT', N'Mayotte')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'ZA', N'South Africa')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'ZM', N'Zambia')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'ZW', N'Zimbabwe')
GO
SET IDENTITY_INSERT [dbo].[Hotel] ON 

INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (1, N'Hotel Artemide', 5, N'ES', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (2, N'H10 Madison', 4, N'FI', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (3, N'A Room With A View', 3, N'ES', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (4, N'Hotel Rec Barcelona', 5, N'ES', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (5, N'Aydinli Cave Hotel', 2, N'ES', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (7, N'Amber Design Residence', 3, N'FI', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (8, N'Hotel Al Ponte Mocenigo', 5, N'RU', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (9, N'La Cachette', 4, N'RU', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (10, N'Celsus Boutique Hotel', 3, N'GB', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (11, N'Ashford Castle', 2, N'RU', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (12, N'Agarta Cave Hotel', 5, N'GB', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (13, N'Sofitel Grand Sopot', 5, N'FI', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (14, N'Grand Resort Bad Ragaz', 4, N'RU', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (15, N'Kelebek Special Cave Hotel', 5, N'GB', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (16, N'A Room With A View', 3, N'GB', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (17, N'Aren Cave Hotel & Art Gallery', 5, N'GE', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (18, N'Castle Hotel Auf Schoenburg', 3, N'GE', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (19, N'Lawton & Lauriston Court Hotel', 5, N'GB', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (20, N'Elif Hanim Hotel & Spa', 3, N'RU', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (21, N'Boutique Hotel Sierra de Alicante', 3, N'RU', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (22, N'Van der Valk Hotel Hoorn', 4, N'RU', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (23, N'Up Hotel', 5, N'RU', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (24, N'Dere Suites', 5, N'FI', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (25, N'Park Dedeman Trabzon', 3, N'RU', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (26, N'Duven Hotel', 5, N'FI', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (27, N'Bandholm Hotel', 2, N'GE', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (28, N'Boutique Hotel El Cresol', 4, N'HR', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (29, N'Perimasali Cave Hotel - Cappadocia', 3, N'HR', N'')
INSERT [dbo].[Hotel] ([Id], [Name], [CountOfStars], [CountryCode], [Description]) VALUES (30, N'Gul Konaklari - Sinasos Rose Mansions', 5, N'HR', N'')
SET IDENTITY_INSERT [dbo].[Hotel] OFF
GO
INSERT [dbo].[HotelOfTour] ([HotelId], [TourId]) VALUES (1, 1)
GO
SET IDENTITY_INSERT [dbo].[Tour] ON 

INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (1, 127, N'Болгарское наследие', N'', NULL, 35700.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (2, 92, N'Волшебный Восток', N'', NULL, 77100.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (3, 72, N'Город с большими амбициями', N'', NULL, 93300.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (4, 143, N'Город четырех ворот', N'', NULL, 72500.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (5, 34, N'Горячий отдых зимой и летом', N'', NULL, 31900.0000, 0)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (6, 43, N'Древний Минск', N'', NULL, 74900.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (7, 224, N'Жемчужина Татарстана', N'', NULL, 65100.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (8, 283, N'Знакомьтесь, Амстердам!', N'', NULL, 68300.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (9, 204, N'Из Алании к загадочным пещерам Алтынбешик', N'', NULL, 55900.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (10, 215, N'Многоликий Сувон', N'', NULL, 62200.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (11, 30, N'Москва поэтическая', N'', NULL, 53200.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (12, 250, N'Незабываемый Дели', N'', NULL, 22500.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (13, 51, N'Отдых на райском острове', N'', NULL, 30900.0000, 0)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (14, 60, N'По старому Таллину', N'', NULL, 28800.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (15, 120, N'Прекрасные острова Греции', N'', NULL, 53700.0000, 0)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (16, 101, N'Романтика белых ночей и разводных мостов', N'', NULL, 54900.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (17, 161, N'Свидание с Хельсинки', N'', NULL, 49100.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (18, 99, N'Сердце Ирана', N'', NULL, 71400.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (19, 25, N'Сердце Северной Карелии', N'', NULL, 62000.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (20, 38, N'Старый город', N'', NULL, 25600.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (21, 292, N'Столица страны Утренней Свежести', N'', NULL, 27600.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (22, 223, N'Страна идеальной гармонии', N'', NULL, 28700.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (23, 286, N'Страна удивительных контрастов', N'', NULL, 50900.0000, 0)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (24, 22, N'Урбанистическая Бразилия', N'', NULL, 80900.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (25, 115, N'Финская крепость', N'', NULL, 70700.0000, 1)
INSERT [dbo].[Tour] ([Id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [IsActual]) VALUES (26, 289, N'Финский романтизм', N'', NULL, 93600.0000, 1)
SET IDENTITY_INSERT [dbo].[Tour] OFF
GO
SET IDENTITY_INSERT [dbo].[Type] ON 

INSERT [dbo].[Type] ([Id], [Name], [Description]) VALUES (1, N'Внутренний туризм', NULL)
INSERT [dbo].[Type] ([Id], [Name], [Description]) VALUES (2, N'Горнолыжные курорты', NULL)
INSERT [dbo].[Type] ([Id], [Name], [Description]) VALUES (3, N'Культурно-исторические туры', NULL)
INSERT [dbo].[Type] ([Id], [Name], [Description]) VALUES (4, N'Лечебно-оздоровительные туры', NULL)
INSERT [dbo].[Type] ([Id], [Name], [Description]) VALUES (5, N'Международный туризм', NULL)
INSERT [dbo].[Type] ([Id], [Name], [Description]) VALUES (6, N'Обслуживание корпоративных клиентов по заказу', NULL)
INSERT [dbo].[Type] ([Id], [Name], [Description]) VALUES (7, N'Пляжные туры', NULL)
INSERT [dbo].[Type] ([Id], [Name], [Description]) VALUES (8, N'Специализированные детские туры', NULL)
INSERT [dbo].[Type] ([Id], [Name], [Description]) VALUES (9, N'Экскурсионные туры', NULL)
SET IDENTITY_INSERT [dbo].[Type] OFF
GO
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (1, 4)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (1, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (1, 7)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (2, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (2, 7)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (3, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (3, 6)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (3, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (4, 3)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (4, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (4, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (5, 4)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (5, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (6, 3)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (6, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (6, 6)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (6, 8)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (6, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (7, 1)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (7, 3)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (7, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (8, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (8, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (9, 3)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (9, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (9, 6)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (9, 7)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (9, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (10, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (10, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (11, 1)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (11, 8)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (12, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (12, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (13, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (13, 7)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (14, 3)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (14, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (14, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (15, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (16, 1)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (16, 6)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (16, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (17, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (17, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (18, 3)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (18, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (18, 6)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (19, 2)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (19, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (20, 3)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (20, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (20, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (21, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (22, 4)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (22, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (23, 3)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (23, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (23, 8)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (23, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (24, 3)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (24, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (24, 7)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (25, 3)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (25, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (25, 8)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (25, 9)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (26, 2)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (26, 5)
INSERT [dbo].[TypeOfTour] ([TourId], [TypeId]) VALUES (26, 6)
GO
ALTER TABLE [dbo].[Hotel]  WITH CHECK ADD  CONSTRAINT [FK_Hotel_Country] FOREIGN KEY([CountryCode])
REFERENCES [dbo].[Country] ([Code])
GO
ALTER TABLE [dbo].[Hotel] CHECK CONSTRAINT [FK_Hotel_Country]
GO
ALTER TABLE [dbo].[HotelComment]  WITH CHECK ADD  CONSTRAINT [FK_HotelComment_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([Id])
GO
ALTER TABLE [dbo].[HotelComment] CHECK CONSTRAINT [FK_HotelComment_Hotel]
GO
ALTER TABLE [dbo].[HotelImage]  WITH CHECK ADD  CONSTRAINT [FK_HotelImage_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([Id])
GO
ALTER TABLE [dbo].[HotelImage] CHECK CONSTRAINT [FK_HotelImage_Hotel]
GO
ALTER TABLE [dbo].[HotelOfTour]  WITH CHECK ADD  CONSTRAINT [FK_HotelOfTour_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([Id])
GO
ALTER TABLE [dbo].[HotelOfTour] CHECK CONSTRAINT [FK_HotelOfTour_Hotel]
GO
ALTER TABLE [dbo].[HotelOfTour]  WITH CHECK ADD  CONSTRAINT [FK_HotelOfTour_Tour] FOREIGN KEY([TourId])
REFERENCES [dbo].[Tour] ([Id])
GO
ALTER TABLE [dbo].[HotelOfTour] CHECK CONSTRAINT [FK_HotelOfTour_Tour]
GO
ALTER TABLE [dbo].[TypeOfTour]  WITH CHECK ADD  CONSTRAINT [FK_TypeOfTour_Tour] FOREIGN KEY([TourId])
REFERENCES [dbo].[Tour] ([Id])
GO
ALTER TABLE [dbo].[TypeOfTour] CHECK CONSTRAINT [FK_TypeOfTour_Tour]
GO
ALTER TABLE [dbo].[TypeOfTour]  WITH CHECK ADD  CONSTRAINT [FK_TypeOfTour_Type] FOREIGN KEY([TypeId])
REFERENCES [dbo].[Type] ([Id])
GO
ALTER TABLE [dbo].[TypeOfTour] CHECK CONSTRAINT [FK_TypeOfTour_Type]
GO
USE [master]
GO
ALTER DATABASE [TuriDemo] SET  READ_WRITE 
GO
