using System;

using System.Data;

using Oracle.DataAccess.Client;

class Example

{

    public static void Main()

    {

        string str = "data source=topcredu;User ID = scott; Password = tiger";

        OracleConnection Conn = new OracleConnection(str);

        //Adapter 생성

        OracleDataAdapter adapter =

        new OracleDataAdapter("select * from emp", Conn);

        //CommandBuilder 개체를 이용하여 SQL 명령을 만든다.

        OracleCommandBuilder builder = new OracleCommandBuilder(adapter);

        //관련된 데이터 테이블들, 행, 열을 담을 DataSet 개체를 만든다.

        DataSet ds = new DataSet();

        //DataAdapter를 이용하여 DataSet에 “사원”이라는 이름으로 데이터를 채운다.

        adapter.Fill(ds, "사원");

        //데이터 건수를 화면에 출력 하자.

        Console.WriteLine(" Data Count : {0}", ds.Tables["사원"].Rows.Count);

        //DataCulumn 배열을 이용하여 기본키를 설정 한다

        //Find를 사용하기 위해 기본키를 설정, 키를 설정 할려면 컬럼의

        //배열에 담아야 한다. 그런다음 그 배열을 PrimaryKey 속성에 배정한다.

        DataColumn[] keys = new DataColumn[1];

        keys[0] = ds.Tables["사원"].Columns["empno"];

        ds.Tables["사원"].PrimaryKey = keys;

        /* 위의것과 또 다른 방법으로 데이터베이스로 부터 직접 기본키 정보를

         얻을 수 있는데 이 경우엔 DataSet을 채우기 전에 명시적으로 키

         정보를 빼먹지 말고 가지고 오라고 해야 한다.

        * adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

        * adapter.Fill(ds, "사원")

        * 이렇게 하면 DataTable의 PrimaryKey 속성을 직접 설정 한 것과 동일한

        효과를 얻는다

        */

        //Find는 키값으로 DataRow 객체를 반환한다. 못찾으면 null을 돌려준다.

        DataRow findrow = ds.Tables["사원"].Rows.Find(7369);

        if (findrow != null)

        {

            findrow.Delete();

            adapter.Update(ds, "사원");

            //삭제 후 데이터 출력

            foreach (DataRow row in ds.Tables["사원"].Rows)

            {

                foreach (DataColumn col in ds.Tables["사원"].Columns)

                    Console.Write("{0, -10}", row[col.ColumnName]);

            }

            Console.WriteLine();

        }

    }

}