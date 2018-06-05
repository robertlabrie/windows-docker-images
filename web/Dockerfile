FROM microsoft/iis
RUN mkdir C:\site
RUN c:\Windows\System32\inetsrv\appcmd.exe delete site "Default Web Site"
RUN c:\Windows\System32\inetsrv\appcmd.exe add site /name:Site /bindings:http://*:80 /physicalpath:"C:\site"
ADD content/ /site
