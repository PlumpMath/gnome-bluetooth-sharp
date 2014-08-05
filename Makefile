G3P = gapi3-parser
G3F = gapi3-fixup
G3C = gapi3-codegen
G3C_FLAGS = `pkg-config --cflags glib-sharp-3.0` `pkg-config --cflags gtk-sharp-3.0`
MCS = dmcs
OPTS = -unsafe -pkg:glib-sharp-3.0 -pkg:gtk-sharp-3.0
OUT = gnome-bluetooth-sharp.dll
TARGET = library

GAPI_SOURCES = gnome-bluetooth.sources
GAPI_RAW = gnome-bluetooth.raw
GAPI_FIX_METADATA = class-fixup.xml
GAPI_API = gnome-bluetooth.xml

SOURCES =  \
	gen/Bluetooth/Category.cs \
	gen/Bluetooth/Chooser.cs \
	gen/Bluetooth/ChooserButton.cs \
	gen/Bluetooth/ChooserCombo.cs \
	gen/Bluetooth/Client.cs \
	gen/Bluetooth/Column.cs \
	gen/Bluetooth/FilterWidget.cs \
	gen/Bluetooth/Global.cs \
	gen/Bluetooth/SettingsWidget.cs \
	gen/Bluetooth/Status.cs \
	gen/Bluetooth/Type.cs \
	gen/GLib/GLibSharp.AsyncReadyCallbackNative.cs \
	gen/Gtk/GtkSharp.TreeModelFilterVisibleFuncNative.cs

all: $(OUT)

$(GAPI_RAW): $(GAPI_SOURCES)
	$(G3P) $(GAPI_SOURCES)

$(GAPI_API): $(GAPI_RAW)
	cp $(GAPI_RAW) $(GAPI_API)
	$(G3F) --api=$(GAPI_API) --metadata=$(GAPI_FIX_METADATA)

$(SOURCES): $(GAPI_API)
	$(G3C) --outdir=gen/ $(G3C_FLAGS) --generate $(GAPI_API)

$(OUT): $(SOURCES)
	$(MCS) $(OPTS) -out:$(OUT) -target:$(TARGET) $(SOURCES)

clean:
	$(RM) $(OUT)

distclean: clean
	$(RM) $(GAPI_RAW)
	$(RM) $(GAPI_API)
	$(RM) -r gen
