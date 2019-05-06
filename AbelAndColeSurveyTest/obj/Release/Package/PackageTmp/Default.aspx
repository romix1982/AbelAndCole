<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AbelAndColeSurveyTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!-- MultiStep Form -->
<div class="row">
    <div class="col-md-6 col-md-offset-3">
       
            <!-- progressbar -->
            <ul id="progressbar">
                <li class="active">Personal Details</li>
                <li>Food Preferences</li>
                <li>Interests</li>
                <li>Comunication</li>
                <li>Thanks</li>
            </ul>
            <!-- fieldsets -->
            <fieldset>
                <h2 class="fs-title">Personal Details</h2>
                <h3 class="fs-subtitle">Tell us something more about you</h3>
                <input type="text"  name="fname" placeholder="First Name"/>
                <input type="text" name="lname" placeholder="Last Name"/>
                <input type="text" name="mail" placeholder="E-Mail"/>
                <input type="button" name="next" class="next action-button" value="Next"/>
            </fieldset>
            <fieldset>
                <h2 class="fs-title">Food Preferences</h2>
                <h3 class="fs-subtitle">How would you define your eating habits?</h3>
               <ul >
                  <li>
                      <input type="radio" id="Voption" name="selector"  value="Vegeterian">
                        <label for="Voption">Vegetarian</label>
                        <div class="check"></div>
                  </li>
                  <li>
                     <input type="radio" id="Vgoption" name="selector" value="Vegan">
                        <label for="Vgoption">Vegan</label>
                        <div class="check"></div>          
                  </li> 
                    <li>
                      <input type="radio" id="Noption" name="selector" value="Neither">
                        <label for="Noption">Neither</label>
                        <div class="check"></div>
                  </li> 
                </ul>
                <input type="button" name="previous" class="previous action-button-previous" value="Previous"/>
                <input type="button" name="next" class="next action-button" value="Next"/>
            </fieldset>
        <fieldset>
                <h2 class="fs-title">Interests</h2>
                <h3 class="fs-subtitle">What are you most interested in?</h3>
               <ul >
                  <li>
                      <input type="radio" id="s-option" name="SeasonalFood">
                        <label for="s-option">Seasonal food</label>
                        <div class="check"></div>
                  </li>
                  <li>
                     <input type="radio" id="r-option" name="Recipes">
                        <label for="r-option">Recipes</label>
                        <div class="check"></div>          
                  </li> 
                    <li>
                      <input type="radio" id="f-option" name="Fruit">
                        <label for="f-option">Fruit</label>
                        <div class="check"></div>
                  </li> 
                   <li>
                      <input type="radio" id="veg-option" name="Veg">
                        <label for="veg-option">Veg</label>
                        <div class="check"></div>
                  </li> 
                   <li>
                      <input type="radio" id="d-option" name="Drinks">
                        <label for="d-option">Drinks</label>
                        <div class="check"></div>
                  </li> 
                   <li>
                      <input type="radio" id="h-option" name="Household">
                        <label for="h-option">Household</label>
                        <div class="check"></div>
                  </li> 
                   
                </ul>
                <input type="button" name="previous" class="previous action-button-previous" value="Previous"/>
                <input type="button" name="next" class="next action-button" value="Next"/>
            </fieldset>
         <fieldset>
                <h2 class="fs-title">Comunication Preferences</h2>
                <h3 class="fs-subtitle">How would you like to receive updates?</h3>
               <ul >
                  <li>
                      <input type="radio" id="e-option" name="Email">
                        <label for="e-option">E-mail</label>
                        <div class="check"></div>
                  </li>
                  <li>
                     <input type="radio" id="a-option" name="App">
                        <label for="a-option">App</label>
                        <div class="check"></div>          
                  </li> 
                    <li>
                      <input type="radio" id="l-option" name="Letter">
                        <label for="l-option">Letter</label>
                        <div class="check"></div>
                  </li> 
                   <li>
                      <input type="radio" id="sms-option" name="SMS">
                        <label for="sms-option">SMS</label>
                        <div class="check"></div>
                  </li> 
                   
                </ul>
                <input type="button" name="previous" class="previous action-button-previous" value="Previous"/>
                <input type="button" name="next" class="next action-button" value="Next"/>
            </fieldset>
            <fieldset>
                <h2 class="fs-title">Thanks for your Opinion</h2>
                <h3 class="fs-subtitle"></h3>
                <img src="https://www.abelandcole.co.uk/src/images/large_logo.svg" width="400" height="200">
                
                    <input type="button" name="previous" class="previous action-button-previous" value="Previous"/>
                    <input type="submit" name="submit" runat="server" class="submit action-button" value="Submit" onserverclick="Submit_Click"/>
                
            </fieldset>

      
    </div>
</div>
<!-- /.MultiStep Form -->

</asp:Content>
