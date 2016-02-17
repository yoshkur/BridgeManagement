﻿Public Class Setting
	'元になるデータが保存されているディレクトリ
	Private _workDirectoryPath As String = "C:\bridge\work"

	'管理番号が保存されているファイル名
	Private _idFile As String = "管理番号.txt"

	'データを取得するExcelファイル名の始まり
	Private _filePrefix As String = "市道"

	'データを取得するExcelシート名
	Private _sheetName As String = "表紙"

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

	'上部工の取得元
	Private _uppermaterialRow As Integer = 15
	Private _uppermaterialColumn As Integer = Asc("C") - Asc("A") + 1

	'下部工の取得元
	Private _undermaterialRow As Integer = 18
	Private _undermaterialColumn As Integer = Asc("C") - Asc("A") + 1

	'支承の取得元
	Private _bearingRow As Integer = 19
	Private _bearingColumn As Integer = Asc("C") - Asc("A") + 1

	'橋面の取得元
	Private _faceRow As Integer = 17
	Private _faceColumn As Integer = Asc("C") - Asc("A") + 1

	Private _saveDirectoryPath As String = "C:\bridge\data"

	Private Shared _singleton As New Setting

	Private Sub New()

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

	Public Property UppermaterialRow As Integer
		Get
			Return _uppermaterialRow
		End Get
		Set(value As Integer)
			_uppermaterialRow = value
		End Set
	End Property

	Public Property UppermaterialColumn As Integer
		Get
			Return _uppermaterialColumn
		End Get
		Set(value As Integer)
			_uppermaterialColumn = value
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
End Class
