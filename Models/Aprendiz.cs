using System;
using System.Collections.Generic;

namespace Models;

public class Aprendiz
{
    protected int ID;
    protected String name;
    protected String EDV;
    protected int loginID;
    protected int turmaID;

    public void setName(String name)
    {
        this.name = name;
    }

    public void setEDV(String EDV)
    {
        this.EDV = EDV;
    }

    public void setLoginID(int loginID)
    {
        this.loginID = loginID;
    }

    public void setTurmaID(int turmaID)
    {
        this.email = email;
    }

    public void setPhone(String phone)
    {
        this.phone = phone;
    }

    public void setLogin(String login)
    {
        this.login = login;
    }
    public void setPasswd(String passwd)
    {
        this.passwd = passwd;
    }
    public String getName()
    {
        return this.name;
    }

    public DateTime getDate_of_birth()
    {        
        return this.date_of_birth;
    }

    public String getDocument()
    {
        return this.document;
    }

    public String getEmail()
    {
        return this.email;
    }

    public String getPhone()
    {
        return this.phone;
    }
    public String getLogin()
    {
        return this.login;
    }
    public String getPasswd()
    {
        return this.passwd;
    }
    public Address getAddress(){
        return address;
    }
}