---
title: Upload Sales
author: James S. K. Makumbi
tags: 'ASP .Net Core, MVC, FileHelper'
date: '2020-09-24'
extensions:
  preset: gfm
featuredImage: 'https://drive.google.com/open?id=1yvPUZ6QqTfHV4IvUIXtG8qTcyLodBGW9'

---

<h1 id="upload-sales-an-asp-.net-core-app-to-upload-csv-files">Upload Sales: An ASP .Net Core App to upload csv files</h1>
<h2 id="interesting-files">Interesting files</h2>
<ol>
<li><a href="http://eforexcel.com/wp/wp-content/uploads/2017/07/100000-Sales-Records.zip">Sample CSV</a>
<ul>
<li><strong>Warning</strong> 10,000 record csv file zipped (use <a href="https://github.com/jmakumbi/UploadSalesCSV/blob/master/SampleCSV/100000%20Sales%20Records.csv">this smaller sixty record one</a> instead).</li>
<li>All headers and precalculated column data provided</li>
<li>No computation required except queries</li>
</ul>
</li>
<li><a href="https://github.com/jmakumbi/UploadSalesCSV/blob/master/Controllers/SalesController.cs">Sales Controller</a>
<ul>
<li>Only one action to import all rows from all csv files in the folder "c:/uploads/"</li>
<li>Uses the <a href="https://www.filehelpers.net/">FileHelpers Library</a></li>
</ul>
</li>
<li><a href="https://github.com/jmakumbi/UploadSalesCSV/blob/master/Controllers/HomeController.cs">Home Controller</a>
<ul>
<li>Only one action to group sales by item</li>
<li>Sum the total profits per item group</li>
<li>Sort the items by total profit descending</li>
<li>Display only top five items</li>
</ul>
</li>
<li><a href="https://github.com/jmakumbi/UploadSalesCSV/blob/master/Views/Home/Index.cshtml">Home View</a>
<ul>
<li>Display top five items with highest total profit</li>
<li>Sort top five items by total profits descending</li>
<li>Filter list by date range (sample data is valid for ranges from 2010-01-01 to 2017-12-31)</li>
</ul>
</li>
<li><a href="https://github.com/jmakumbi/UploadSalesCSV/blob/master/Views/Sales/Index.cshtml">Sales View</a></li>
</ol>
<h2 id="screenshots">Screenshots</h2>
<h3 id="version-1">Version 1</h3>
<p><img src="https://github.com/jmakumbi/UploadSalesCSV/blob/master/Screenshots/Version%201/2020-09-24_17-52-26.png" alt="Home View"><br>
<img src="https://github.com/jmakumbi/UploadSalesCSV/blob/master/Screenshots/Version%201/2020-09-24_17-53-02.png" alt="Sales View"></p>
<h2 id="using">Using</h2>
<ol>
<li><strong>Put <a href="https://github.com/jmakumbi/UploadSalesCSV/blob/master/SampleCSV/100000%20Sales%20Records.csv">CSV</a> in a folder called uploads on the C: partition of your pc</strong></li>
<li>Click on Sales</li>
<li>Click on home</li>
<li>To filter home screen data;
<ul>
<li>Input from date</li>
<li>Input to date</li>
<li>click on filter</li>
</ul>
</li>
</ol>
<h2 id="how-do-you-run-it">How do you run it?</h2>
<ol>
<li>Clone the project</li>
<li>Restore Nuget Packages</li>
<li>Install FileHelpers by running <code>Install-Package FileHelpers</code> in the Package manager console</li>
<li>
<blockquote>
<p>Create uploads folder on your C: partition. <strong>This is important</strong></p>
</blockquote>
</li>
<li>Put csv file(s) in <code>c:/uploads/</code></li>
</ol>
<h2 id="future-not-in-order-of-priority">Future (not in order of priority)</h2>
<ul>
<li class="task-list-item"><input type="checkbox" class="task-list-item-checkbox" disabled=""> <strong>Add unit tests</strong></li>
<li class="task-list-item"><input type="checkbox" class="task-list-item-checkbox" disabled=""> Refactor all controller code</li>
<li class="task-list-item"><input type="checkbox" class="task-list-item-checkbox" disabled=""> Switch from <a href="https://www.filehelpers.net/">FileHelpers Library</a></li>
<li class="task-list-item"><input type="checkbox" class="task-list-item-checkbox" disabled=""> Implement tracking of uploaded files to prevent duplicate upload</li>
<li class="task-list-item"><input type="checkbox" class="task-list-item-checkbox" disabled=""> Move data upload to files view and controller</li>
<li class="task-list-item"><input type="checkbox" class="task-list-item-checkbox" disabled=""> Implement file upload by dialog instead of hardcoded path</li>
<li class="task-list-item"><input type="checkbox" class="task-list-item-checkbox" disabled=""> Check for duplicate records on upload</li>
<li class="task-list-item"><input type="checkbox" class="task-list-item-checkbox" disabled=""> Check for empty fields</li>
<li class="task-list-item"><input type="checkbox" class="task-list-item-checkbox" disabled=""> Fix the currency columns to display correctly</li>
<li class="task-list-item"><input type="checkbox" class="task-list-item-checkbox" disabled=""> Implement a <a href="https://www.wikiwand.com/en/CSS_framework">CSS framework</a> like <a href="https://getbootstrap.com/">Bootstrap)</a>, <a href="https://tailwindcss.com/">Tailwind</a>, or <a href="https://semantic-ui.com/">Semantic UI</a></li>
<li class="task-list-item"><input type="checkbox" class="task-list-item-checkbox" disabled=""> Implement full CRUD</li>
</ul>

