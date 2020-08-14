<?php
session_start();

?>
<!DOCTYPE html>
<html>
<head>
<title>Crime Reporting - User</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link href="layout/styles/main.css" rel="stylesheet" type="text/css" media="all">
<link href="layout/styles/mediaqueries.css" rel="stylesheet" type="text/css" media="all">

</head>
<body class="">
<div class="wrapper row1">
  <header id="header" class="full_width clear">
    <div id="hgroup">
      <h1>Crime Reporting</h1>
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
<div class="wrapper row2">
  <nav id="topnav">
    <ul class="clear">
      <li class="active"><a href="index.html" title="Homepage">Homepage</a></li>
      <li><a href="../user/report-crime/report-crime.php" title="Report Crime">Report Crime</a></li>
      <li><a class="drop" href="#" title="Resources">Resources</a> 
        <ul>
         <li><a href="../user/resource/faq.html" title="FAQ">FAQ</a></li>
         <li><a href="../user/resource/crime-tips.html" title="Crime safety Tips">Crime Safety Tips</a></li>
         <li><a href="../user/resource/page-1.html" title="Crime Details">Crime Details</a></li>
        </ul>
      </li>
      <li><a href="../user/contact-us/contact.html" title="Feedback">Feedback</a></li>  
      <li><a href="../user/helpline/helpline.html" title="Helpline">Helpline</a></li>   
    </ul>
  </nav>
</div>
<!-- ################################################################################################ -->
<div class="wrapper row2">
  <!-- ################################################################################################ -->
 <div id="intro">
    <div class="boxholder"><img src="images/demo/crime-scene-1200x400.png" alt=""></div>
  </div>
  <!-- ################################################################################################ -->
 <div class="clear"></div>
</div>
<!-- content -->
<div class="wrapper row3">
  <div id="container">
    <!-- ################################################################################################ -->
    <div id="homepage" class="clear">
      <section class="last">
        <div class="one_quarter first">
          <h2>Emergency Call</h2>
          <article> 
            <p>Please contact local police in case of an emergency</p>
              <p>National police helpline number is <b>100</b>.</p> 
              <p>National women helpline number is <b>181</b>.</p>
          </article>
        </div>
        <div class="one_half">
          <article>
            <h2>Filing a Complaint on Crime Reporting Portal</h2>
            <img src="images/demo/Capture3.PNG">
            <p>This portal is to facilitate victims/complaints to report crime complaints online.</p>
            <p>It is imperative to provide correct and accurate details while filing complaint for prompt action.</p>
            <div>
                <ul class="nospace demo_li_space"> 
                  <a href="resource/page-1.html" class="button medium gradient orange">Learn about crime</a> &emsp; &emsp; &emsp; &emsp; &emsp; &emsp; &emsp; &emsp; &emsp;
                  <a href="report-crime/report-crime.php" class="button medium gradient orange">File a Complaint</a> 
                </ul> 
            </div>
          </article>
        </div>
        <div class="one_quarter">
          <h2>Different Types of Complaints</h2>
          <ul class="list arrow">
            <li><a href="complaints/complaint-1.html">Organized Crime</a></li>
            <li><a href="complaints/complaint-2.html">Illegal drug trade</a></li>
            <li><a href="complaints/complaint-3.html">Arms Trafficking</a></li>
            <li><a href="complaints/complaint-4.html">Poaching & Wildlife trafficking</a></li>
            <li><a href="complaints/complaint-5.html">Cyber Crime</a></li>
            <li><a href="complaints/complaint-6.html">Corruption & Police misconduct</a></li>
            <li><a href="complaints/complaint-7.html">Crime over Time</a></li>
          </ul>
        </div>
      </section>
    </div>
    <!-- ################################################################################################ -->
    <div class="clear"></div>
  </div>
</div>

<!-- Scripts -->
<script src="https://code.jquery.com/jquery-latest.min.js"></script>
<script src="https://code.jquery.com/ui/1.10.1/jquery-ui.min.js"></script>
<script>window.jQuery || document.write('<script src="layout/scripts/jquery-latest.min.js"><\/script>\
<script src="layout/scripts/jquery-ui.min.js"><\/script>')</script>
<script>jQuery(document).ready(function($){ $('img').removeAttr('width height'); });</script>
<script src="layout/scripts/jquery-mobilemenu.min.js"></script>
<script src="layout/scripts/custom.js"></script>
</body>
</html>