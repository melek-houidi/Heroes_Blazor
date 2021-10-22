<%@ Page Title="Zobi form" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="form_page.aspx.cs" Inherits="ContactForm.form_page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section id="main-content">
        <section id="wrapper">

            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-4 col-md-offset-4">
                                <h1>Contact Form Zobi</h1>
                            </div>
                        </header>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Name" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Name" ID="nametextbox" />
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Last Name" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Last Name" />
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Date" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" textMode="Date" CssClass="form-control input-sm" placeholder="Name" />
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Put Your Email" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" placeholder=" Put Your Email" />
                                    </div>
                                </div>
                            </div>



                        <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Region" runat="server" />
                                        <asp:DropDownList runat="server" CssClass="form-control input-sm" ID="regiondropdown">
                                            <asp:ListItem Text="Tunis" />
                                            <asp:ListItem Text="India" />
                                            <asp:ListItem Text="Frensh" />
                                            <asp:ListItem Text="China" />

                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Confirm Your Email" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Confirm Your Email" />
                                    </div>
                                </div>
                            </div>


                         <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Cell No" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" textMode="Phone" CssClass="form-control input-sm" placeholder="Phone" />
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Choose" runat="server" />
                                        <asp:RadioButtonList runat="server" >
                                            <asp:listItem text="Male" />
                                            <asp:ListItem Text="Female" />
                                         </asp:RadioButtonList>
                                    </div>
                                </div>
                            </div>

                        <div class="row">
                            <div class="col-md-8 col-md-offset-2">
                                <asp:Button Text="Save" ID="btnsave" CssClass="btn btn-primary" width="170px" runat="server" OnClick="btnsave_Click" />
                                <asp:Button Text="Update" ID="Button1" CssClass="btn btn-primary" width="170px" runat="server" />
                                <asp:Button Text="Delete" ID="Button2" CssClass="btn btn-danger" width="170px" runat="server" />
                            </div>

                        </div>



                    </section>
                </div>
            </div>

        </section>




    </section>



</asp:Content>
