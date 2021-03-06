SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[供应商信息]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[供应商信息](
	[编号] [int] IDENTITY(1,1) NOT NULL,
	[供应商] [varchar](255) NULL,
	[TEL] [varchar](255) NULL,
	[FAX] [varchar](255) NULL,
	[联系人] [varchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sales]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sales](
	[加入序号] [int] IDENTITY(1,1) NOT NULL,
	[订单日期] [datetime] NULL,
	[订单编号] [varchar](255) NULL,
	[版本号] [varchar](255) NULL,
	[订单描述] [varchar](500) NULL,
	[商品代码] [varchar](255) NULL,
	[商品名称] [varchar](255) NULL,
	[订单交期] [datetime] NULL,
	[签订单位] [varchar](255) NULL,
	[签订数量] [varchar](255) NULL,
	[赠品数量] [varchar](255) NULL,
	[有无其他零部件] [varchar](10) NULL,
	[生产状态] [varchar](255) NULL CONSTRAINT [DF_sales_生产状态]  DEFAULT ('未生产'),
	[销售单价] [varchar](255) NULL,
	[币别] [varchar](255) NULL,
	[销售金额] [varchar](255) NULL,
	[出货日期] [datetime] NULL,
	[出货数量] [varchar](255) NULL,
	[收款金额] [varchar](255) NULL,
	[收款时间] [datetime] NULL,
	[备注] [varchar](1000) NULL,
	[核销] [varchar](20) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[其他零部件]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[其他零部件](
	[编号] [int] IDENTITY(1,1) NOT NULL,
	[订单日期] [datetime] NULL,
	[订单编号] [varchar](255) NULL,
	[版本号] [varchar](255) NULL,
	[商品代码] [varchar](255) NULL,
	[商品名称] [varchar](255) NULL,
	[签订单位] [varchar](255) NULL,
	[签订数量] [varchar](30) NULL,
	[销售单价] [varchar](255) NULL,
	[销售金额] [varchar](255) NULL,
	[币别] [varchar](255) NULL,
	[备注] [varchar](1000) NULL,
	[核销] [varchar](20) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[生产日志]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[生产日志](
	[编号] [int] IDENTITY(1,1) NOT NULL,
	[日期] [datetime] NULL,
	[订单编号] [varchar](255) NULL,
	[商品名称] [varchar](255) NULL,
	[生产线] [varchar](50) NULL,
	[签订数量] [int] NULL,
	[日产量] [int] NULL,
	[累积] [int] NULL,
	[剩余数量] [varchar](255) NULL,
	[作业工时] [varchar](255) NULL,
	[作业人数] [varchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[用户管理]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[用户管理](
	[编号] [int] IDENTITY(1,1) NOT NULL,
	[用户名] [varchar](255) NULL,
	[密码] [varchar](255) NULL,
	[基础物料] [varchar](10) NULL,
	[成品] [varchar](10) NULL,
	[销售管理] [varchar](10) NULL,
	[采购管理] [varchar](10) NULL,
	[仓库管理_物料] [varchar](10) NULL,
	[仓库管理_成品] [varchar](10) NULL,
	[生产管理] [varchar](10) NULL,
	[设置] [varchar](10) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[material]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[material](
	[名称] [nvarchar](255) NULL,
	[全名] [nvarchar](255) NULL,
	[商品类型] [nvarchar](255) NULL,
	[规格型号] [nvarchar](255) NULL,
	[基本单位] [nvarchar](255) NULL,
	[计价方法] [nvarchar](255) NULL,
	[代码] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_material] PRIMARY KEY CLUSTERED 
(
	[代码] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[production]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[production](
	[num] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[code] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[num] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[purchase]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[purchase](
	[编号] [int] IDENTITY(1,1) NOT NULL,
	[采购单号] [varchar](255) NULL,
	[序号] [int] NULL,
	[物料编号] [int] NULL,
	[规格] [varchar](255) NULL,
	[单位] [varchar](10) NULL,
	[用量] [int] NULL,
	[数量] [int] NULL,
	[单价] [varchar](255) NULL,
	[物料用途] [varchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[当前生产订单]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[当前生产订单](
	[编号] [int] IDENTITY(1,1) NOT NULL,
	[订单编号] [varchar](255) NULL,
	[商品名称] [varchar](255) NULL,
	[签订数量] [varchar](255) NULL,
	[累积] [varchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[成品库存信息]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[成品库存信息](
	[编号] [int] IDENTITY(1,1) NOT NULL,
	[代码] [varchar](255) NOT NULL,
	[名称] [varchar](255) NULL,
	[库存] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[库存日志]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[库存日志](
	[编号] [int] IDENTITY(1,1) NOT NULL,
	[日期] [datetime] NULL,
	[商品类别] [varchar](255) NULL,
	[代码] [varchar](255) NULL,
	[名称] [varchar](255) NULL,
	[入出库类别] [varchar](255) NULL,
	[数量] [varchar](255) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[采购信息]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[采购信息](
	[编码] [int] IDENTITY(1,1) NOT NULL,
	[日期] [datetime] NULL,
	[采购单序号] [int] NULL,
	[物料序号] [int] NULL,
	[物料代码] [int] NULL,
	[名称] [varchar](255) NULL,
	[全名] [varchar](255) NULL,
	[规格] [varchar](255) NULL,
	[单位] [varchar](255) NULL,
	[数量] [int] NULL,
	[单价] [varchar](255) NULL,
	[是否含税] [varchar](20) NULL,
	[金额] [varchar](255) NULL,
	[物料用途] [varchar](255) NULL,
	[是否取消] [varchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[库存信息]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[库存信息](
	[编号] [int] IDENTITY(1,1) NOT NULL,
	[物料代码] [int] NOT NULL,
	[名称] [varchar](255) NULL,
	[全名] [varchar](255) NULL,
	[库存] [int] NULL,
 CONSTRAINT [PK__库存信息__5DCAEF64] PRIMARY KEY CLUSTERED 
(
	[物料代码] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_ma]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pr_ma](
	[pr_num] [int] NULL,
	[ma_num] [int] NULL
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[kucunfk]') AND parent_object_id = OBJECT_ID(N'[dbo].[库存信息]'))
ALTER TABLE [dbo].[库存信息]  WITH CHECK ADD  CONSTRAINT [kucunfk] FOREIGN KEY([物料代码])
REFERENCES [dbo].[material] ([代码])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[pmfk1]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_ma]'))
ALTER TABLE [dbo].[pr_ma]  WITH CHECK ADD  CONSTRAINT [pmfk1] FOREIGN KEY([pr_num])
REFERENCES [dbo].[production] ([num])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[pmfk2]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_ma]'))
ALTER TABLE [dbo].[pr_ma]  WITH CHECK ADD  CONSTRAINT [pmfk2] FOREIGN KEY([ma_num])
REFERENCES [dbo].[material] ([代码])
ON UPDATE CASCADE
ON DELETE CASCADE
