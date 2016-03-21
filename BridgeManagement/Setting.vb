Imports System.IO

Public Class Setting
    '元になるデータが保存されているディレクトリ
    Private _workDirectoryPath As String = "D:\bridge\work"

    '管理番号が保存されているファイル名
    Private _idFile As String = "管理番号.txt"

    'データを取得するExcelファイル名の始まり
    Private _filePrefix As String = "市道"

    'データを取得するExcelシート名
    Private _sheetName As String = "道路橋様式1P001"
    'Private _sheetName As String = "表紙"

    '最新点検年度の取得元
    Private _inspectionyearRow As Integer = 9
    Private _inspectionyearColumn As Integer = Asc("D") - Asc("A") + 1

    '点検者の取得元
    Private _inspectionerRow As Integer = 12
    Private _inspectionerColumn As Integer = Asc("G") - Asc("A") + 1

    '路下条件の取得元
    Private _underconditionRow As Integer = 9
    Private _underconditionColumn As Integer = Asc("F") - Asc("A") + 1

    '代替路の有無の取得元
    Private _alternatepathRow As Integer = 9
    Private _alternatepathColumn As Integer = Asc("H") - Asc("A") + 1

    '自専道or一般道の取得元
    Private _generalroadRow As Integer = 9
    Private _generalroadColumn As Integer = Asc("I") - Asc("A") + 1

    '緊急輸送道路の取得元
    Private _emergencyroadRow As Integer = 9
    Private _emergencyroadColumn As Integer = Asc("K") - Asc("A") + 1

    '占用条件の取得元
    Private _occupancyRow As Integer = 9
    Private _occupancyColumn As Integer = Asc("L") - Asc("A") + 1

    '健全度の取得元
    Private _soundnessRow As Integer = 25
    Private _soundnessColumn As Integer = Asc("A") - Asc("A") + 1

    '上部工主桁の取得元
    Private _uppermaterialmainRow As Integer = 15
    Private _uppermaterialmainColumn As Integer = Asc("C") - Asc("A") + 1

    '上部工横桁の取得元
    Private _uppermaterialsideRow As Integer = 16
    Private _uppermaterialsideColumn As Integer = Asc("C") - Asc("A") + 1

    '上部工床桁の取得元
    Private _uppermaterialfloorRow As Integer = 17
    Private _uppermaterialfloorColumn As Integer = Asc("C") - Asc("A") + 1

    '下部工の取得元
    Private _undermaterialRow As Integer = 18
    Private _undermaterialColumn As Integer = Asc("C") - Asc("A") + 1

    '支承の取得元
    Private _bearingRow As Integer = 19
    Private _bearingColumn As Integer = Asc("C") - Asc("A") + 1

    '橋面の取得元
    Private _faceRow As Integer = 20
    Private _faceColumn As Integer = Asc("C") - Asc("A") + 1

    '点検データ保存ディレクトリ
    Private _saveDirectoryPath As String = "D:\bridge\data"

    '調査の間隔
    Private _inspectionspan As Integer = 5

    Private Shared _singleton As New Setting

    Private Sub New()
        Try
            Dim excelController As New ExcelControllClass
            Dim appPath As String = System.Windows.Forms.Application.StartupPath
            excelController.openFile(Path.Combine(appPath, "BridgeManagementSetting.xlsx"), False)
            excelController.setWorkSheet("BridgeManagement")

            Me._workDirectoryPath = excelController.Cells(1, 2).Text
            Me._idFile = excelController.Cells(2, 2).Text
            Me._filePrefix = excelController.Cells(3, 2).Text
            Me._sheetName = excelController.Cells(4, 2).Text
            Me._inspectionyearRow = excelController.Cells(5, 2).Text
            Me._inspectionyearColumn = Me.getColumnNumber(excelController.Cells(6, 2).Text)
            Me._inspectionerRow = excelController.Cells(7, 2).Text
            Me._inspectionerColumn = Me.getColumnNumber(excelController.Cells(8, 2).Text)
            Me._underconditionRow = excelController.Cells(9, 2).Text
            Me._underconditionColumn = Me.getColumnNumber(excelController.Cells(10, 2).Text)
            Me._alternatepathRow = excelController.Cells(11, 2).Text
            Me._alternatepathColumn = Me.getColumnNumber(excelController.Cells(12, 2).Text)
            Me._generalroadRow = excelController.Cells(13, 2).Text
            Me._generalroadColumn = Me.getColumnNumber(excelController.Cells(14, 2).Text)
            Me._emergencyroadRow = excelController.Cells(15, 2).Text
            Me._emergencyroadColumn = Me.getColumnNumber(excelController.Cells(16, 2).Text)
            Me._occupancyRow = excelController.Cells(17, 2).Text
            Me._occupancyColumn = Me.getColumnNumber(excelController.Cells(18, 2).Text)
            Me._soundnessRow = excelController.Cells(19, 2).Text
            Me._soundnessColumn = Me.getColumnNumber(excelController.Cells(20, 2).Text)
            Me._uppermaterialmainRow = excelController.Cells(21, 2).Text
            Me._uppermaterialmainColumn = Me.getColumnNumber(excelController.Cells(22, 2).Text)
            Me._uppermaterialsideRow = excelController.Cells(23, 2).Text
            Me._uppermaterialsideColumn = Me.getColumnNumber(excelController.Cells(24, 2).Text)
            Me._uppermaterialfloorRow = excelController.Cells(25, 2).Text
            Me._uppermaterialfloorColumn = Me.getColumnNumber(excelController.Cells(26, 2).Text)
            Me._undermaterialRow = excelController.Cells(27, 2).Text
            Me._undermaterialColumn = Me.getColumnNumber(excelController.Cells(28, 2).Text)
            Me._bearingRow = excelController.Cells(29, 2).Text
            Me._bearingColumn = Me.getColumnNumber(excelController.Cells(30, 2).Text)
            Me._faceRow = excelController.Cells(31, 2).Text
            Me._faceColumn = Me.getColumnNumber(excelController.Cells(32, 2).Text)
            Me._saveDirectoryPath = excelController.Cells(33, 2).Text
            Me._inspectionspan = Me.getColumnNumber(excelController.Cells(34, 2).Text)

            excelController.close(False)
        Catch ex As Exception
        End Try

    End Sub

    Public Shared Function getInstance() As Setting
        Return _singleton
    End Function

    Public Property WorkDirectoryPath As String
        Get
            Return _workDirectoryPath
        End Get
        Set(value As String)
            _workDirectoryPath = value
        End Set
    End Property

    Public ReadOnly Property FilePrefix As String
        Get
            Return _filePrefix
        End Get
    End Property

    Public ReadOnly Property IdFile As String
        Get
            Return _idFile
        End Get
    End Property

    Public Property InspectionyearRow As Integer
        Get
            Return _inspectionyearRow
        End Get
        Set(value As Integer)
            _inspectionyearRow = value
        End Set
    End Property

    Public Property InspectionyearColumn As Integer
        Get
            Return _inspectionyearColumn
        End Get
        Set(value As Integer)
            _inspectionyearColumn = value
        End Set
    End Property

    Public Property InspectionerRow As Integer
        Get
            Return _inspectionerRow
        End Get
        Set(value As Integer)
            _inspectionerRow = value
        End Set
    End Property

    Public Property InspectionerColumn As Integer
        Get
            Return _inspectionerColumn
        End Get
        Set(value As Integer)
            _inspectionerColumn = value
        End Set
    End Property

    Public Property UnderconditionRow As Integer
        Get
            Return _underconditionRow
        End Get
        Set(value As Integer)
            _underconditionRow = value
        End Set
    End Property

    Public Property UnderconditionColumn As Integer
        Get
            Return _underconditionColumn
        End Get
        Set(value As Integer)
            _underconditionColumn = value
        End Set
    End Property

    Public Property AlternatepathRow As Integer
        Get
            Return _alternatepathRow
        End Get
        Set(value As Integer)
            _alternatepathRow = value
        End Set
    End Property

    Public Property AlternatepathColumn As Integer
        Get
            Return _alternatepathColumn
        End Get
        Set(value As Integer)
            _alternatepathColumn = value
        End Set
    End Property

    Public Property GeneralroadRow As Integer
        Get
            Return _generalroadRow
        End Get
        Set(value As Integer)
            _generalroadRow = value
        End Set
    End Property

    Public Property GeneralroadColumn As Integer
        Get
            Return _generalroadColumn
        End Get
        Set(value As Integer)
            _generalroadColumn = value
        End Set
    End Property

    Public Property EmergencyroadRow As Integer
        Get
            Return _emergencyroadRow
        End Get
        Set(value As Integer)
            _emergencyroadRow = value
        End Set
    End Property

    Public Property EmergencyroadColumn As Integer
        Get
            Return _emergencyroadColumn
        End Get
        Set(value As Integer)
            _emergencyroadColumn = value
        End Set
    End Property

    Public Property OccupancyRow As Integer
        Get
            Return _occupancyRow
        End Get
        Set(value As Integer)
            _occupancyRow = value
        End Set
    End Property

    Public Property OccupancyColumn As Integer
        Get
            Return _occupancyColumn
        End Get
        Set(value As Integer)
            _occupancyColumn = value
        End Set
    End Property

    Public Property SoundnessRow As Integer
        Get
            Return _soundnessRow
        End Get
        Set(value As Integer)
            _soundnessRow = value
        End Set
    End Property

    Public Property SoundnessColumn As Integer
        Get
            Return _soundnessColumn
        End Get
        Set(value As Integer)
            _soundnessColumn = value
        End Set
    End Property

    Public Property UndermaterialRow As Integer
        Get
            Return _undermaterialRow
        End Get
        Set(value As Integer)
            _undermaterialRow = value
        End Set
    End Property

    Public Property UndermaterialColumn As Integer
        Get
            Return _undermaterialColumn
        End Get
        Set(value As Integer)
            _undermaterialColumn = value
        End Set
    End Property

    Public Property BearingRow As Integer
        Get
            Return _bearingRow
        End Get
        Set(value As Integer)
            _bearingRow = value
        End Set
    End Property

    Public Property BearingColumn As Integer
        Get
            Return _bearingColumn
        End Get
        Set(value As Integer)
            _bearingColumn = value
        End Set
    End Property

    Public Property FaceRow As Integer
        Get
            Return _faceRow
        End Get
        Set(value As Integer)
            _faceRow = value
        End Set
    End Property

    Public Property FaceColumn As Integer
        Get
            Return _faceColumn
        End Get
        Set(value As Integer)
            _faceColumn = value
        End Set
    End Property

    Public Property SaveDirectoryPath As String
        Get
            Return _saveDirectoryPath
        End Get
        Set(value As String)
            _saveDirectoryPath = value
        End Set
    End Property

    Public Property SheetName As String
        Get
            Return _sheetName
        End Get
        Set(value As String)
            _sheetName = value
        End Set
    End Property

    Public Property Inspectionspan As Integer
        Get
            Return _inspectionspan
        End Get
        Set(value As Integer)
            _inspectionspan = value
        End Set
    End Property

    Public Property UppermaterialmainRow As Integer
        Get
            Return _uppermaterialmainRow
        End Get
        Set(value As Integer)
            _uppermaterialmainRow = value
        End Set
    End Property

    Public Property UppermaterialmainColumn As Integer
        Get
            Return _uppermaterialmainColumn
        End Get
        Set(value As Integer)
            _uppermaterialmainColumn = value
        End Set
    End Property

    Public Property UppermaterialsideRow As Integer
        Get
            Return _uppermaterialsideRow
        End Get
        Set(value As Integer)
            _uppermaterialsideRow = value
        End Set
    End Property

    Public Property UppermaterialsideColumn As Integer
        Get
            Return _uppermaterialsideColumn
        End Get
        Set(value As Integer)
            _uppermaterialsideColumn = value
        End Set
    End Property

    Public Property UppermaterialfloorRow As Integer
        Get
            Return _uppermaterialfloorRow
        End Get
        Set(value As Integer)
            _uppermaterialfloorRow = value
        End Set
    End Property

    Public Property UppermaterialfloorColumn As Integer
        Get
            Return _uppermaterialfloorColumn
        End Get
        Set(value As Integer)
            _uppermaterialfloorColumn = value
        End Set
    End Property

    Private Function getColumnNumber(columnLetter As String) As Integer
        Return Asc(columnLetter) - Asc("A") + 1
    End Function
End Class
