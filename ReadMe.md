


# Upload Sales: An ASP .Net Core App to upload csv files
## Interesting files
1. [Sample CSV](http://eforexcel.com/wp/wp-content/uploads/2017/07/100000-Sales-Records.zip)
	- __Warning__ 10,000 record csv file zipped (use [this smaller sixty record one](https://github.com/jmakumbi/UploadSalesCSV/blob/master/SampleCSV/100000%20Sales%20Records.csv) instead).
	- All headers and precalculated column data provided
	- No computation required except queries
2. [Sales Controller](https://github.com/jmakumbi/UploadSalesCSV/blob/master/Controllers/SalesController.cs)
	- Only one action to import all rows from all csv files in the folder "c:/uploads/"
	- Uses the [FileHelpers Library](https://www.filehelpers.net/)
3. [Home Controller](https://github.com/jmakumbi/UploadSalesCSV/blob/master/Controllers/HomeController.cs)
	- Only one action to group sales by item
	- Sum the total profits per item group
	- Sort the items by total profit descending
	- Display only top five items
4. [Home View](https://github.com/jmakumbi/UploadSalesCSV/blob/master/Views/Home/Index.cshtml)
	- Display top five items with highest total profit
	- Sort top five items by total profits descending
	- Filter list by date range (sample data is valid for ranges from 2010-01-01 to 2017-12-31)
5. [Sales View](https://github.com/jmakumbi/UploadSalesCSV/blob/master/Views/Sales/Index.cshtml)
## Screenshots
### Version 1
![Home View](https://github.com/jmakumbi/UploadSalesCSV/blob/master/Screenshots/Version%201/2020-09-24_17-52-26.png)


![Sales View](https://github.com/jmakumbi/UploadSalesCSV/blob/master/Screenshots/Version%201/2020-09-24_17-53-02.png)
## Using
1. **Put [CSV](https://github.com/jmakumbi/UploadSalesCSV/blob/master/SampleCSV/100000%20Sales%20Records.csv) in a folder called uploads on the C: partition of your pc**
2. Click on Sales
3. Click on home
4. To filter home screen data;
	- Input from date
	- Input to date
	- click on filter
## How do you run it?
1. Clone the project
2. Restore Nuget Packages
3. Install FileHelpers by running `Install-Package FileHelpers` in the Package manager console
4. >Create uploads folder on your C: partition. **This is important**
5. Put csv file(s) in `c:/uploads/`
## Future (not in order of priority)
- [ ] **Add unit tests**
- [ ] Switch from [FileHelpers Library](https://www.filehelpers.net/)
- [ ] Implement tracking of uploaded files to prevent duplicate upload
- [ ] Move data upload to files view and controller
- [ ] Implement file upload by dialog instead of hardcoded path
- [ ] Check for empty fields
- [ ] Fix the currency columns to display correctly
- [ ] Implement a [CSS framework](https://www.wikiwand.com/en/CSS_framework) like [Bootstrap)](https://getbootstrap.com/), [Tailwind](https://tailwindcss.com/), or [Semantic UI](https://semantic-ui.com/)
- [ ] Implement full CRUD




<!--stackedit_data:
eyJwcm9wZXJ0aWVzIjoidGl0bGU6IFVwbG9hZCBTYWxlc1xuYX
V0aG9yOiBKYW1lcyBTLiBLLiBNYWt1bWJpXG50YWdzOiAnQVNQ
IC5OZXQgQ29yZSwgTVZDLCBGaWxlSGVscGVyJ1xuZGF0ZTogJz
IwMjAtMDktMjQnXG5leHRlbnNpb25zOlxuICBwcmVzZXQ6IGdm
bVxuZmVhdHVyZWRJbWFnZTogJ2h0dHBzOi8vZHJpdmUuZ29vZ2
xlLmNvbS9vcGVuP2lkPTF5dlBVWjZRcVRmSFY0SXZVSVh0Rzhx
VGN5TG9kQkdXOSdcbiIsImhpc3RvcnkiOlsxMTU1Nzc0NjEwLD
ExNjQ5NTUxNzRdfQ==
-->