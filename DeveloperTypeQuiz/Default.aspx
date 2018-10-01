<%--<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="firstProject1._Default" %>--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="firstProject1._Default" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

    <%--Style sheets--%>


    <link href="Content/MyCss.css" rel="stylesheet" />

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />



    <%-- J-query--%>
    <script src="Scripts/jquery-1.10.2.min.js"></script>


    <%--Bootstrap--%>

    <script src="javascripts/bootstrap.min.js"></script>


    <%-- google Charts--%>
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script src="Scripts/MyChart.js"></script>




    <title>Devoloper type quiz</title>
</head>


<body>

    <div id="bgImage">
        <div class="container ">
            <form id="form1" runat="server">

                <div id="mainQuiz">



                    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">

                        <asp:View ID="View0" runat="server">

                            <h1 class=" Devquiz well">Developer type quiz </h1>
                            <p class="p1">Interested in programming? Haven't decided yet if you're more suited for front-end or back-end? This quiz will help you decide.</p>

                            <p class="p2">Press Start when you are ready to begin!</p>
                            <asp:Button ID="ButtonStart" class=" btn btn-info center-block" runat="server" Text="Start" CausesValidation="false" OnClick="ButtonStart_Click" />


                        </asp:View>


                        <asp:View ID="View1" runat="server">
                            <p class="questions">What would you enjoy most ?</p>
                        </asp:View>

                        <asp:View ID="View2" runat="server">
                            <p class="questions">What would you enjoy most ?</p>
                        </asp:View>

                        <asp:View ID="View3" runat="server">
                            <p class="questions">What would be you preference ?</p>
                        </asp:View>

                        <asp:View ID="View4" runat="server">
                            <p class="questions">Where would you prefer working?</p>
                        </asp:View>

                        <asp:View ID="View5" runat="server">
                            <p class="questions">Your website would rather..</p>
                        </asp:View>
                        <asp:View ID="View6" runat="server">
                            <p class="questions">Would you be more interested in</p>
                        </asp:View>

                        <asp:View ID="View7" runat="server">
                            <p class="questions">Which of these describes you the most?</p>
                        </asp:View>

                        <asp:View ID="View8" runat="server">
                            <p class="questions">Take a moment to think ! Where do you see yourself?</p>

                        </asp:View>

                        <asp:View ID="View9" runat="server">


  
                            <div class="row">

                                <div class="  well well-sm results col-xs-12 ">Your Quiz results</div>
                            </div>

                       <div class="resultsView">

                            <div class="row">


                                <div class="col-sm-offset-4 col-sm-4" id="resultsChart"></div>

                            </div>

                            <div class="row">

                                <div class=" col-sm-12 resultsMessage ">
                                    <asp:Label ID="resultsMessage" runat="server" Visible="false"></asp:Label>
                                </div>

                             </div>

                           
                       </div>




                        </asp:View>
                    </asp:MultiView>



                    <div class="RBL">
                        <asp:RadioButtonList ID="RBL" runat="server" Visible="False" EnableViewState="True" ValidationGroup="VG" CausesValidation="True">
                            <asp:ListItem Value="fE"></asp:ListItem>
                            <asp:ListItem Value="bE"></asp:ListItem>

                        </asp:RadioButtonList>

                    </div>

                    <div>
                        <asp:RequiredFieldValidator ID="selectValidator" runat="server" ErrorMessage="You must select an answer" Display="Dynamic" ControlToValidate="RBL" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </div>



                    <div class="row">
                        <asp:Button ID="previousButton" CausesValidation="false" class="btn btn-info" runat="server" Text="Previous" OnClick="PreviousButton_Click" Visible="False" />
                        <asp:Button ID="nextButton" class="btn btn-info" runat="server" Text="Next" OnClick="NextButton_Click" Visible="False" />
                        <asp:Button ID="finishedButton" class="btn btn-info" runat="server" Text="Finished" OnClick="finishedButton_Click" Visible="False" />
                       <div class="RestartButton"> <asp:Button ID="RestartButton" class="btn btn-info" runat="server" Text="Restart" Visible="False" OnClick="RestartButton_Click" /></div>
                    </div>




                </div>
                <%--mainquiz--%>
            </form>
        </div>
        <%--container--%>
    </div>
    <%--bgimage--%>
</body>
</html>












