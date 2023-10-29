extends TextureRect


export var correct_level = 0
export var text = "No text"

func _ready() -> void:
	var qr_code: QrCode = QrCode.new()
	qr_code.error_correct_level = correct_level
	var imageTexture: ImageTexture = qr_code.get_texture(text)


	texture = imageTexture;
