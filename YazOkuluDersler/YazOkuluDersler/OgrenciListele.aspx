<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListele.aspx.cs" Inherits="OgrenciListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci Id</th>
            <th>Öğrenci Adı</th>
            <th>Öğrenci Soyadı</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Bakiye</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="repeater1" runat="server">
                <itemtemplate>
                    <tr>
                        <td><%#Eval("ID")%></td>
                        <td><%#Eval("AD")%></td>
                        <td><%#Eval("SOYAD")%></td>
                        <td><%#Eval("NUMARA")%></td>
                        <td><%#Eval("SIFRE")%></td>
                        <td><%#Eval("BAKİYE")%></td>
                        <td><%#Eval("FOTOGRAF")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl=<%#"~/OgrenciSil.aspx?OGRID="+Eval("ID") %> ID="hyperlink1" runat="server" cssClass="btn btn-danger">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl=<%#"~/OgrenciGuncelle.aspx?OGRID="+Eval("ID") %> ID="hyperlink2" runat="server" cssClass="btn btn-success">Güncelle</asp:HyperLink>
                            
                        </td>
                    </tr>
                </itemtemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

