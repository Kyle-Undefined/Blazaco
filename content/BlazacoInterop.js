const BlazorEditors = [];

window.BlazacoFunctions = {
    BlazorEditors: BlazorEditors,

    InitializeEditor: function (editorModel) {
        console.debug(`Registering new editor ${editorModel.id}...`);

        let thisEditor = monaco.editor.create(document.getElementById(editorModel.id), {
            automaticLayout: true,
            language: editorModel.language,
            theme: editorModel.theme,
            value: editorModel.value,
            minimap: {
                enabled: true
            }
        });

        if (BlazorEditors.find(e => e.id === editorModel.id)) {
            console.error(`Duplicate editor ${editorModel.id}`);
            return false;
        }
        else {
            console.debug(`Registered new editor ${editorModel.id}`);
            BlazorEditors.push({ id: editorModel.id, editor: thisEditor});
        }        
        return true;
    },

    GetValue: function (editorModel) {
        console.debug(`Getting editor value for ${editorModel.id}...`);
        let myEditor = BlazorEditors.find(e => e.id === editorModel.id);
        console.debug(`Found: ${myEditor}`);
        if (!myEditor) {
            throw `Could not find a editor with id: '${BlazorEditors.length}' '${editorModel.id}'`;
        }

        editorModel.Value = myEditor.editor.getValue();
        console.debug(`Value: ${myEditor.editor.getValue()}`);

        return editorModel;
    },

    SetValue: function (editorModel) {
        console.debug(`Setting editor value for ${editorModel.id}...`);
        let myEditor = BlazorEditors.find(e => e.id === editorModel.id);
        console.debug(`Found: ${myEditor}`);
        if (!myEditor) {
            throw `Could not find a editor with id: '${BlazorEditors.length}' '${editorModel.id}'`;
        }

        myEditor.editor.setValue(editorModel.value);
        console.debug(`Setting value success.`);

        return editorModel;
    },

    SetTheme: function (editorModel) {
        console.debug(`Setting editor theme for ${editorModel.id}...`);
        let myEditor = BlazorEditors.find(e => e.id === editorModel.id);
        console.debug(`Found: ${myEditor}`);
        if (!myEditor) {
            throw `Could not find a editor with id: '${BlazorEditors.length}' '${editorModel.id}'`;
        }

        monaco.editor.setTheme(editorModel.theme);
        console.debug(`Setting theme success.`);

        return editorModel;
    }
}
