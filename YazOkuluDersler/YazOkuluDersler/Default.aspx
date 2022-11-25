<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">


        <div class="form-group">

            <br />
            <br />
                        <div>
                            <strong>
                            <asp:Label ID="label1" for="txtAd" Text="Öğrenci Adı:" runat="server" style="font-size: large" />
                            </strong>
                            <asp:TextBox ID="txtAd" runat="server" CssClass="form-control" />
                        </div>
            <br />
            <br />
                        <div>
                            <strong>
                            <asp:Label ID="label2" for="txtSoyad" Text="Öğrenci Soyadı:" runat="server" style="font-size: large" />
                            </strong>
                            <asp:TextBox ID="txtSoyad" runat="server" CssClass="form-control" />
                        </div>
            <br />
            <br />
                        <div>
                            <strong>
                            <asp:Label ID="label3" for="txtNumara" Text="Numara:" runat="server" style="font-size: large" />
                            </strong>
                            <asp:TextBox ID="txtNumara" runat="server" CssClass="form-control" />
                        </div>
            <br />
            <br />
                        <div>
                            <strong>
                            <asp:Label ID="label4" for="txtSifre" Text="Sifre:" runat="server" style="font-size: large" />
                            </strong>
                            <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control" />
                        </div>
            <br />
            <br />
                        <div>
                            <strong>
                            <asp:Label ID="label5" for="txtFoto" Text="Fotoğraf:" runat="server" style="font-size: large" />
                            </strong>
                            <asp:TextBox ID="txtFoto" runat="server" CssClass="form-control" />
                        </div>

            <br />
            <br />
        </div>
        
        

        <asp:Button ID="Button1" Text="Kaydet" runat="server" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>
</asp:Content>

