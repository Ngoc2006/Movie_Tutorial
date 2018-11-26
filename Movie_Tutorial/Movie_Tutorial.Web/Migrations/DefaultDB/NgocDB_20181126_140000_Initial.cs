using FluentMigrator;
using System;

namespace Movie_Tutorial.Migrations.NgocDB
{

    [Migration(20181126140000)]
    public class NgocDB_20181126_140000_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            Console.WriteLine("Haha. Chay roi, de tao db moi");
        }
    }
}