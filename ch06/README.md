# Homework6 说明

​	第六次作业比较难，需要完成EF框架下的数据库增删改查和WebApi的发步。为了简便，我把这两个内容都用一个.Net Core项目一并完成了。

​	OrderAppController中所有的方法均已经使用Postman测试过了，测试的Request打包好放在了与Readme同级的目录下面。

​	在第六次示例代码EFDemo的运行测试时，遇到了MySql一直无法正常操作的问题，在对DbSet对象使用Add方法时会产生NullReference问题。在排查了版本、框架、NuGet库等方面的原因后，最后通过StackOverflow上的一个帖子的方法，将OrderContext的建表方式改为总是重新建表解决了这个问题。

​	后来用.Net Core完成作业的过程中没有遇到连接MySql的问题，.Net Core还是挺舒服的。