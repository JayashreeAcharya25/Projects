<?php

$name='';
$email='';
$connect=mysqli_connect("localhost","root","","crimedb");
session_start();
 
 
?>
<!DOCTYPE html>
<html>
<head>
<title>Report crime</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link href="../layout/styles/main.css" rel="stylesheet" type="text/css" media="all">
<link href="../layout/styles/mediaqueries.css" rel="stylesheet" type="text/css" media="all">

</head>
<body class="">
<div class="wrapper row1">
  <header id="header" class="full_width clear">
    <div id="hgroup">
      <h1><a href="../index.html">Crime Reporting</a></h1>
      <h2>User</h2>
    </div>
    <div id="header-contact">
      <ul class="list none">
        <li><span class="icon-envelope"></span> <a href="#">info@domain.com</a></li>
        <li><span class="icon-phone"></span> +xx xxx xxxxxxxxxx</li>
      </ul>
    </div>
  </header>
</div>
<!-- ################################################################################################ -->
<!-- content -->
<div class="wrapper row3">
  <div id="container">
    <!-- ################################################################################################ -->
    <section class="clear">
      <h1>Report Complaint</h1>
    </section>
    <div id="respond" >
      <form class="rnd5" action="report-insert.php" method="post">
        <div class="form-input clear">
          <label class="one_third first" for="name">Name <span class="required">*</span><br>
            <input type="text" name="name" id="name"  size="22" value="">
           </label>
        </div>
          <div class="form-input clear">
            <label class="one_third" for="email">Email <span class="required">*</span><br>
               <input type="text" name="email" id="email" value="" size="22">
      </label>
          </div>
          <div class="form-input clear">
             <label class="one_third" for="phone">Phone Number<span class="required">*</span><br>
                <input type="number" name="phone" id="phone" value="" size="22">
             </label>
          </div>
          <div class="form-input clear">
             <label class="one_third" for="address">Address<span class="required">*</span><br>
                 <input type="text" name="address" id="address" value="" size="22">
             </label>
          </div>
          <div class="form-input clear"> 
              <label class="one_third" for="file">Attach file<br>
                <input class="button medium white" name="filetoupload" id="filetoupload" type="file" style="display: inline-block" value="Select file"/> 
              </label>   
          </div>
         <div class="form-input clear">
             <label class="one_third" for="list">crime<span class="required">*</span><br>
                 <select name="selected">
                   <option>Drug trafficking</option>
                   <option>Gunrunning </option>
                   <option>Money laundering</option>
                   <option>Extortion </option>
                   <option>Murder for hire </option>
                   <option>Fraud</option>
                   <option>Human trafficking</option>
                   <option>Poaching </option>
                   <option>Black marketing </option>
                   <option>Political violence</option>
                   <option>Religious violence  </option>
                   <option>Abduction</option>
                   <option>Computer hacking</option>
                   <option>Cyber stalking</option>
                   <option>E-mail fraud </option>
                   <option>Spam </option>
                   <option>Corruption </option>
                   <option>Bribes </option>
                   <option>Tax evasion </option>
                   <option>Passport theft </option>
                   <option>Robbery</option>
                   <option>Murder </option>
                   <option>Kidnapping </option>
                 </select>
             </label>
          </div>
        <div class="form-message">
           <label class="one_third" for="file">Description<br>
            <textarea name="message" id="message" cols="25" rows="5"></textarea>
          </label>
        </div>
        <div class="form-input clear">
          <input class="button medium orange" type="submit" value="Submit"/>
          &nbsp;
          <input class="button medium orange" type="reset" value="Reset">
        </div>
      </form>
    </div>
     <div class="wrapper row3">
     <div id="container">
      <p class="clear"><a class="fl_left" href="javascript:history.go(-1)">&laquo; Go Back</a> <a class="fl_right" href="../index.html">Go Home &raquo;</a></p>
      </div>
    </div>
    <!-- ################################################################################################ -->
    <div class="clear"></div>
  </div>
</div>
<!-- Scripts -->
<script src="https://code.jquery.com/jquery-latest.min.js"></script>
<script src="https://code.jquery.com/ui/1.10.1/jquery-ui.min.js"></script>
<script>window.jQuery || document.write('<script src="../layout/scripts/jquery-latest.min.js"><\/script>\
<script src="../layout/scripts/jquery-ui.min.js"><\/script>')</script>
<script>jQuery(document).ready(function($){ $('img').removeAttr('width height'); });</script>
<script src="../layout/scripts/jquery-mobilemenu.min.js"></script>
<script src="../layout/scripts/custom.js"></script>
</body>
</html>