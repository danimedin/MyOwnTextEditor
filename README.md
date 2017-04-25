# MyOwnTextEditor
Este é un exercicio onde se desexa practicar os contidos do módulo de Deseño de Interfaces. Farase en varias iteracións,
engadindo novas funcionalidades pouco a pouco.

Trátase de facer un editor de texto similar ao coñecido Notepad++. 
Non imos a programar todas as funcionalidades pero si as máis destacadas en relación ao módulo.

Primeira iteración

Nesta primeira iteración, debe presentase unha única ventá. 
Está ventá presentará unha barra de menús e un área de contido (RichTextBox). 

En canto aos menús, os seus elementos deben ter accesos directos e imaxes:

File

	New - deixará limpa a área de contido.
	
	Open – abrirá un OpenFileDialog, deixará seleccionar un arquivo de texto e este se mostrará na área de contido.
	
	Save – permitirá gardar o arquivo, supoñendo que teña un nome ou ruta asociada.
	
	Save AS – abrirá un SaveAsFileDialog, deixará seleccionar un arquivo de texto e se gardará.
	
	Close – pechará o aplicativo.
	
Edit
	Cut
	
	Copy
	
	Paste
	
	Do
	
	Undo
	
Search

	Find
	
	Find & Replace
	
?

	About
	
Ademais, debe programarse que cando a área de contido foi modificada, en caso de pechar o aplicativo ou premer nos ítems de menú New ou Open debe mostrar unha advertencia de que o arquivo non está gardado. Esta advertencia debe mostar un Dialogbox preguntando se quere gardar, se non quere gardar ou cancelar. En caso de escoller gardar débese abrir o SaveAsDialog (se non ten nome de arquivo asociado previamente). 
Por suposto, o proxecto debe estar dispoñible en GitHub.

Nesta segunda iteración, debe traballarse sobre a primeira iteración. Debe incorporarse unha barra de ferramentas cos seguintes iconas:
	New
	Open
	Save
	Copy
	Cut
	Paste
	Find
	Do
	Undo
Os botóns New, Open e Save deben ter a mesma funcionalidade que os seus homólogos do menú.
Por outra banda, debe cambiarse a área de texto onde se mostraba o contido do arquivo por un panel de lapelas. Este panel, ao abrirse a aplicación terá unha única lapela onde se mostrará un area de texto. Ademais o panel, terá unha lapela cun símbolo +. Cando se pulse sobre ela, debe crearse unha lapela nova cun area de texto vacía.

