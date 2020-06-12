本项目所使用的IDE版本为VS2017，框架版本为.Net4.6.1。如果你的IDE无法启动，请打开BankSystem\bin\Debug\BankSystem.exe进行体验。
针对作业的采分点，本人对本项目说明如下：
1.本项目采用面向对象编程思想，主要的类有Account(账户类)、Bank(银行类)、ATM(ATM类继承自窗体Form)、CreditAccount(继承自Account类)以及一系列用于展示的窗体类，具体类的字段和方法可以见项目中的类图文件ClassDiagram.cd
2.属性的使用：Account.cs中有4个自动属性、Bank.cs中使用了属性Count、CreditAccount.cs中使用了3个属性
索引的使用：Bank中使用索引器对账户列表进行增删改查的操作，但仅用于类内部使用(private修饰了)
3.使用继承：CreditAccount继承自Account，并覆写了2个方法
4.其他语法要素：使用了接口IMoneyStorable，Bank和ATM实现了该接口，该接口为能够储藏钱的对象提供了增加钱数、减少钱数、金钱调配（可用于银行于ATM机之间的调配），该接口为银行管理员提供了管理钱的方法。（本方法没有具体的使用，因为在本项目中还不涉及银行管理员，这些方法也有待完善，例如增加管理员权限的验证）